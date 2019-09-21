using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticOperations
{
    public partial class F_ArithmeticOperations : Form
    {
        private int system;
        public F_ArithmeticOperations()
        {
            InitializeComponent();
        }
        private void text_press_system(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            if (!(i == 8 || Char.IsDigit(c)))
            {
                //  запрет ввода любых символов, кроме
                // цифр и backspace
                e.Handled = true;
            }
        }
        private void text_press(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            int n_syst = lb_NumericSystem.SelectedIndex;
            // запрет ввода любых символов, кроме
            // backspace, цифр и букв диапазона A-F (заглавных)
            if ((n_syst == 3) && (!(i == 8 || (i >= 48 && i <= 57)|| (i >= 65 && i <= 70)))
                // backspace, запрет любых символов, кроме цифр 0 и 1)
                || (n_syst == 0) && (!(i == 8 || (i == 48 || i == 49)))
                // backspace, запрет любых символов, кроме цифр 0 до 7)
                || (n_syst == 1) && (!(i == 8 || (i >= 48 && i <= 55)))
                // backspace, запрет любых символов, кроме цифр)
                || (n_syst == 2) && !(i == 8 || Char.IsDigit(c)))
            {
                
                e.Handled = true;
            }
        }

        private void error_handling()
        {
            try
            {
                if (tb_number1.Text == "" | tb_number2.Text == "" | lb_NumericSystem.SelectedIndex < 0)
                {
                    throw new Exception("Внимание! Проверьте, пожалуйста, " +
                        "обязательное для заполнения поле (одно или несколько) не заполнено!");
                }

                if (lb_OperationSelection.SelectedIndex < 0)
                {
                    throw new Exception("Внимание! Не выбран элемент в списке!");
                }

            }
            catch (Exception ex)
            {
                tb_result.Text = ($"Ошибка: {ex.Message}");
                tb_result.ForeColor = Color.Red;
            }

        }
        private void error2_handling()
        {
            try
            {
                
            }
            catch(System.ArgumentOutOfRangeException ex)
            {
                tb_result.Text = ($"Ошибка: {ex.Message}");
                tb_result.ForeColor = Color.Red;
            }
            
        }
        private void add_one_number_to_another()
        {

                string number1 = tb_number1.Text;
                string number2 = tb_number2.Text;
                int num1 = Convert.ToInt32(number1, system);
                int num2 = Convert.ToInt32(number2, system);
                int result = num1 + num2;
                string result1 = Convert.ToString(result, system);
                if (lb_NumericSystem.SelectedIndex == 3)
                {
                    result1 = result1.ToUpper();
                }

                tb_result.ForeColor = Color.DarkBlue;
                tb_result.AppendText(number1 + " + " + number2 + " = " + result1 + Environment.NewLine);
                tb_result.AppendText("_________________________" + Environment.NewLine);
                tb_result.AppendText("Ответ: " + result1 + Environment.NewLine);
           

        }


        private void subtract_one_number_from_another()
        {
            
           try
            {
                string number1 = tb_number1.Text;
                string number2 = tb_number2.Text;
                int num1 = Convert.ToInt32(number1, system);
                int num2 = Convert.ToInt32(number2, system);
                int result = num1 - num2;
                if (result < 0) throw new Exception("В настойщее время программа " +
                   "не поддерживает отрицательные числа, " +
                   "а результатом вычитания станет отрицательное число."); 
                string result1 = Convert.ToString(result, system);
                if (lb_NumericSystem.SelectedIndex == 3)
                {
                    result1 = result1.ToUpper();
                }
                tb_result.ForeColor = Color.DarkBlue;
                tb_result.AppendText(number1 + " - " + number2 + " = " + result1 + Environment.NewLine);
                tb_result.AppendText("_________________________" + Environment.NewLine);
                tb_result.AppendText("Ответ: " + result1 + Environment.NewLine);
            }
            catch (Exception ex)
            {
                tb_result.Text = ($"Ошибка: {ex.Message}");
                tb_result.ForeColor = Color.Red;
            }
        }

        private void B_calculate_MouseDown(object sender, MouseEventArgs e)
        {
            tb_result.Clear();
            error_handling();
            error2_handling();
            if (lb_OperationSelection.SelectedIndex == 0)
            {
                add_one_number_to_another();
            }

            if (lb_OperationSelection.SelectedIndex == 1)

            {
                subtract_one_number_from_another();
            }

        }

        private void Tb_NumericSystem_TextChanged(object sender, EventArgs e)
        {

        }


        private void Lb_NumericSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_NumericSystem.SelectedIndex >= 0)
            {
                tb_number1.Enabled = true;
                lb_OperationSelection.Enabled = true;
                tb_number2.Enabled = true;
                tb_number1.Clear();
                tb_number2.Clear();

            }

            switch (lb_NumericSystem.SelectedIndex)
            {
                case 0:
                    tb_result.Text = "Выбрана 2-ва ичная система счисления";
                    system = 2;
                    break;
                case 1:
                    tb_result.Text = "Выбрана 8-ми ричная система счисления ";
                    system = 8;
                    break;
                case 2:
                    tb_result.Text = "Выбрана 10-ти ричная система счисления ";
                    system = 10;
                    break;
                case 3:
                    tb_result.Text = "Выбрана 16-ти ричная система счисления ";
                    system = 16;
                    break;

            }
        }

        private void Lb_OperationSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lb_OperationSelection.SelectedIndex)
            {
                case 0:
                    tb_result.Text = "Выбрана оперция сложения";
                    break;
                case 1:
                    tb_result.Text = "Выбрана операция вычитания";
                    break;
            }
         }

        private void Tb_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
    }

