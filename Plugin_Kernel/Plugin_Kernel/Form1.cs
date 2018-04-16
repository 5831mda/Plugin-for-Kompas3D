using System;
using System.Windows.Forms;
using Kompas6API5;



namespace Plugin_Kernel
{

    public partial class Form : System.Windows.Forms.Form
    {
        private KompasObject kompas;
        
        
        public Form()
        {
            InitializeComponent();        
        }

        /// <summary>
        /// обработчик событий при нажатии на кнопку "Открыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (kompas == null)
                {
                    Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                    kompas = (KompasObject)Activator.CreateInstance(t);
                }
                if (kompas != null)
                {
                    kompas.Visible = true;
                    kompas.ActivateControllerAPI();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Вероятно Компас 3D был открыт не с помощью плагина", "Ошибка открытия компаса", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// обработчик событий при нажатии на кнопку "закрыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosedButton_Click(object sender, EventArgs e)
        {
            try
            {
                kompas.Quit();
                kompas = null;
            }
            catch
            {
                MessageBox.Show("Компас не открыт", "Ошибка при закрытии",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// обработчик событий при нажатии на кнопку "создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Parameters param = new Parameters();
                param.Angle1 = double.Parse(F1textBox.Text);
                param.Angle2 = double.Parse(F2textBox.Text);
                param.Radios1 = double.Parse(D1textBox.Text);
                param.Radios2 = double.Parse(D2textBox.Text);
                param.Lenght1 = double.Parse(L1textBox.Text);
                param.Lenght2 = double.Parse(L2textBox.Text);


                if (param.Angle1 > param.Radios2)
                {
                    MessageBox.Show("Длина фаски не должна превышать радиус верхней части стержня",
                              "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (70 < param.Angle2 || param.Angle2 < 1)
                {
                    MessageBox.Show("Угол выдавливания должен быть\n не меньше 1 и не больше 70", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(param.Radios1 < param.Radios2)
                {
                    MessageBox.Show("Радиус нижней части стержня должен быть\nбольше радиуса верхней части",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(param.Radios1 < 7 || param.Radios2 < 5 || param.Lenght1 < 10 ||
                    param.Lenght2 < 15 || param.Angle1 < 2 || param.Angle2 < 22)
                {
                    MessageBox.Show("Значения меньше минимальных\nПоменяйте значения и повторите", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (param.Radios1 > 999 || param.Radios2 > 800 || param.Lenght1 > 999 ||
                   param.Lenght2 > 999 || param.Angle1 > 400 || param.Angle2 > 70)
                {
                    MessageBox.Show("Значения превышают максимальные\nПоменяйте значения и повторите", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    CreatorDetail detail = new CreatorDetail(kompas);
                    detail.DownCircle(param);
                    detail.MiddleCircle(param);
                    detail.UpCircle(param);
                    detail.CreateChamfer(param);
                    detail.FlatPart(param);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания детали\nНажмите 'Открыть' и повторите", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// валидация параметров детали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateKeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
            {
                MessageBox.Show("Вводить можно только числа", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        /// <summary>
        /// пока есть пустые текст боксы кнопка создать не активна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlltextBox_TextChanged(object sender, EventArgs e)
        {
            if (D1textBox.Text == "" || D2textBox.Text == "" || L1textBox.Text == "" ||
                L2textBox.Text == "" || F1textBox.Text == "" || F2textBox.Text == "")

                CreateButton.Enabled = false;
            else
                CreateButton.Enabled = true;

        }

        /// <summary>
        /// выбор минимальных, максимальных и рекомендумых параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    { 
                        D1textBox.Text = Convert.ToString(999);
                        D2textBox.Text = Convert.ToString(800);
                        L1textBox.Text = Convert.ToString(999);
                        L2textBox.Text = Convert.ToString(999);
                        F1textBox.Text = Convert.ToString(400);
                        F2textBox.Text = Convert.ToString(70);
                        break;
                    }
                case 1:
                    {
                        D1textBox.Text = Convert.ToString(15);
                        D2textBox.Text = Convert.ToString(10);
                        L1textBox.Text = Convert.ToString(70);
                        L2textBox.Text = Convert.ToString(100);
                        F1textBox.Text = Convert.ToString(4);
                        F2textBox.Text = Convert.ToString(45);
                        break;
                    }
                case 2:
                    {
                        D1textBox.Text = Convert.ToString(7);
                        D2textBox.Text = Convert.ToString(5);
                        L1textBox.Text = Convert.ToString(10);
                        L2textBox.Text = Convert.ToString(15);
                        F1textBox.Text = Convert.ToString(2);
                        F2textBox.Text = Convert.ToString(22);
                        break;
                    }
            }
        }
    }
}
                                                                                    

        

