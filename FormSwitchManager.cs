using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metafusion
{
    internal class FormSwitchManager
    {
        private static bool isSwitching = false;
        public static Dictionary<string, Form> Forms { get; private set; } = new Dictionary<string, Form>(); //필요한 경우 form 저장
        public static void AppendForm(Form form, string form_name)
        {
            if (Forms.ContainsKey(form_name))
            {
                // 이미 form이 있는 경우 skip
                return;
            }
            else
            {
                // Key에 대응하는 값이 없는 경우 처리
                Forms.Add(form_name, form);
            }
        }
        public static Form GetForm(string form_name)
        {
            if (Forms.ContainsKey(form_name))
            {
                // Key에 대응하는 값이 있는 경우 처리
                return Forms[form_name];
            }
            else
            {
                // Key에 대응하는 값이 없는 경우 처리
                //MessageBox.Show($"Error:Key '{form_name}' not found in Forms dictionary.");
                return null;
            }
        }
        public static bool RemoveForm(string form_name)
        {
            if (Forms.ContainsKey(form_name))
            {   
                Form to_dispose = GetForm(form_name);
                // Key에 대응하는 값이 있는 경우 처리
                bool success = Forms.Remove(form_name);
                if(success)
                    to_dispose.Dispose();
                return success;
            }
            else
            {
                // Key에 대응하는 값이 없는 경우 처리
                //MessageBox.Show($"Error:Key '{form_name}' not found in Forms dictionary.");
                return false;
            }
        }
        public static Form CreateForm(string next_form_name)
        {
            //manage page index
            int page_index = 0;
            switch (next_form_name)
            {
                case "item1":
                    page_index = 1;
                    break;
                case "item3":
                    page_index = 2;
                    break;
                case "item5":
                    page_index = 3;
                    break;
                case "itemtooth":
                    page_index = 4;
                    break;
                default:
                    break;
            }
            //create and manage forms
            Form new_form;
            switch (next_form_name)
            {
                case "item1":
                case "item3":
                case "item5":
                case "itemtooth":
                    new_form = GetForm(next_form_name);
                    if (new_form == null)
                        new_form = new PageItemDetail();
                    new_form.SuspendLayout();
                    ((PageItemDetail)new_form).SetPageIndex(page_index);
                    new_form.ResumeLayout();
                    break;
                case "viewer":
                    new_form = GetForm(next_form_name);
                    if (new_form == null)
                        new_form = new PageViewer();
                    break;
                default: //todo
                    new_form = GetForm("home");
                    if (new_form == null)
                        new_form = new PageHome();
                    break;
            }
            return new_form; //failed to create
        }
        public static async void try_Switch(Form current_form, string current_form_name, string next_form_name)
        {
            if (isSwitching || current_form_name == next_form_name) // avoid form duplication or multiple switches
                return;
            isSwitching = true;

            // 현재 폼의 위치와 크기 저장
            Point currentLocation = current_form.Location;
            Size currentSize = current_form.Size;
            FormWindowState currentState = current_form.WindowState;
            Rectangle restoreBounds = current_form.RestoreBounds;

            //Dictionary에 현재 폼 저장
            AppendForm(current_form, current_form_name);

            Form new_form = CreateForm(next_form_name);

            // 새 폼의 위치와 크기 및 최대화 상태 설정
            new_form.SuspendLayout();
            if (currentState == FormWindowState.Maximized)
            {
                // RestoreBounds 적용
                new_form.Location = restoreBounds.Location;
                new_form.Size = restoreBounds.Size;
                new_form.Bounds = restoreBounds;
                new_form.WindowState = currentState;
            }
            else
            {
                
                //maximized 됐던 경우 hidden 상태에서 windowstate 변경 불가능 -> 삭제 후 재생성.. (maximize -> swap -> normalize -> swap 인 경우 handle)
                //지금 보니 잘 되는 것 같긴 한데, flicker-free를 위해서..
                if(new_form.WindowState == FormWindowState.Maximized && next_form_name != "home")
                {
                    RemoveForm(next_form_name);
                    new_form = CreateForm(next_form_name);
                }

                //일반적인 경우
                new_form.WindowState = currentState;
                new_form.Location = currentLocation;
                new_form.Size = currentSize;
            }
            new_form.ResumeLayout();

            // 새 폼 보여주기
            current_form.BringToFront();
            new_form.Show();
            //to avoid flickering on transition
            //current_form.SendToBack(); 
            //new_form.BringToFront();
            new_form.WindowState = currentState;
            new_form.Location = currentLocation;
            new_form.Size = currentSize;
            await Task.Delay(100);
            current_form.Hide();
            isSwitching = false;
        }
    }
}
