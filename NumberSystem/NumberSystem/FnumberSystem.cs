using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace NumberSystem
{
    public partial class FnumberSystem : Form
    {
        public FnumberSystem()
        {
            InitializeComponent();
        }
        private void decimal_conversion_to_another()
        {
            int number, system_entry, system_exit;
            int result;
            number = Convert.ToInt32(t_number.Text);
            system_exit = Convert.ToInt32(t_system_exit.Text);
            int proviso_number = Convert.ToInt32(t_system_entry.Text);
            int i = 0;
            int[] nums = new int[50];
            t_result.AppendText("Решение" + Environment.NewLine);
            do
            {
                result = number / system_exit;
                nums[i] = number % system_exit;
                t_result.AppendText("Число " + number + "/" + system_exit + " Остаток " + nums[i] + Environment.NewLine);
                i++;
                number = result;
                if (number < system_exit)
                {
                    nums[i] = result;
                    t_result.AppendText("Число " + number + " < " + system_exit + Environment.NewLine);
                }
            } while (number >= system_exit);
            t_result.AppendText("Для получения ответа записываем числа остатков в обратном порядке:" + Environment.NewLine);
            t_result.AppendText("Ответ:");
            for (int v = i; v >= 0; v--)
            {
                if (system_exit == 16)
                {
                    switch (nums[v])
                    {
                        case 10:
                            t_result.AppendText("A");
                            break;
                        case 11:
                            t_result.AppendText("B");
                            break;
                        case 12:
                            t_result.AppendText("C");
                            break;
                        case 13:
                            t_result.AppendText("D");
                            break;
                        case 14:
                            t_result.AppendText("E");
                            break;
                        case 15:
                            t_result.AppendText("F");
                            break;
                        default:
                            t_result.AppendText("" + nums[v]);
                            break;
                    }
                }

                if (system_exit != 16) t_result.AppendText("" + nums[v]);

            }
        }
     
        private void transfer_from_other_to_decimal()
            {
            string text = t_number.Text;
            char[] obrtext = text.ToCharArray();
            Array.Reverse(obrtext);
            string finaltext = new string(obrtext);
            int proviso_number = Convert.ToInt32(t_system_entry.Text);
            int[] c = new int[finaltext.Length];
            // из массива char(или строки) получаем массив int
            if (t_system_entry.Text !="16") { c = finaltext.Select(x => x - '0').ToArray(); }
            else
            {
                for (int i = 0; i < finaltext.Length; i++)
                {

                    switch (finaltext[i])
                    {
                        case 'A':
                            c[i] = 10;
                            break;
                        case 'B':
                            c[i] = 11;
                            break;
                        case 'C':
                            c[i] = 12;
                            break;
                        case 'D':
                            c[i] = 13;
                            break;
                        case 'E':
                            c[i] = 14;
                            break;
                        case 'F':
                            c[i] = 15;
                            break;
                        default:
                            c[i] = (int)(obrtext[i] - '0');
                            break;
                    }

                    
                }

            }

                // рассчеты
                t_result.AppendText("Решение" + Environment.NewLine);
            for (int i = 0; i < c.Length; i++)
            {
                int a = c[i];
                c[i] = a * Convert.ToInt32(Math.Pow(proviso_number, i));
                t_result.AppendText(" " + a + " * " + Convert.ToInt32(Math.Pow(proviso_number, i)) + Environment.NewLine);
                if(i < c.Length - 1) t_result.AppendText(" + " + Environment.NewLine);
                if(i == c.Length - 1) t_result.AppendText(" = " + Environment.NewLine);
            }
           int sum = 0; 
           foreach (int num in c) sum += num;
            t_result.AppendText("Ответ:" + Environment.NewLine);
            t_result.AppendText(" " + sum + Environment.NewLine);


        }
        private void B_start_Click(object sender, EventArgs e)
        {
            t_result.Clear();
            try
            {
               if (t_number.Text =="" | t_system_entry.Text =="" | t_system_exit.Text =="")
                {                   
                        throw new Exception("Внимание! Проверьте, пожалуйста, " +
                            "обязательное для заполнения поле (одно или несколько) не заполнено!");        
                }

                
               if (t_system_entry.Text == "10")
                {
                    decimal_conversion_to_another();
                }
                else
                {
                   transfer_from_other_to_decimal();
                }
            }
            catch (Exception ex)
            {
                t_result.Text =($"Ошибка: {ex.Message}");
                t_result.ForeColor = Color.Red;
            }
            

        }
    }
}
