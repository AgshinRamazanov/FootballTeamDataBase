using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet12.Enroll". При необходимости она может быть перемещена или удалена.
            this.enrollTableAdapter.Fill(this.dataSet12.Enroll);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Enroll". При необходимости она может быть перемещена или удалена.
            this.enrollTableAdapter.Fill(this.dataSet11.Enroll);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Parent". При необходимости она может быть перемещена или удалена.
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Coach". При необходимости она может быть перемещена или удалена.
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Player". При необходимости она может быть перемещена или удалена.
            this.playerTableAdapter.Fill(this.dataSet1.Player);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter.Fill(this.dataSet1.Team);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teamTableAdapter.Insert(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int T_ID;
            int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);
            teamTableAdapter.DeleteTeam(T_ID);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int PL_AGE;
            int T_ID;
            int.TryParse(textBox5.Text.ToString(),out PL_AGE );
            int.TryParse(comboBox8.SelectedValue.ToString(), out  T_ID);
            playerTableAdapter.Insert(textBox3.Text, textBox4.Text, PL_AGE,T_ID );
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int PL_ID;
            int.TryParse(comboBox2.SelectedValue.ToString(), out PL_ID);
            playerTableAdapter.DeletePlayer(PL_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            int C_PH;
            int T_ID;
            int.TryParse(textBox9.Text.ToString(), out C_PH);
            int.TryParse(comboBox9.SelectedValue.ToString(), out T_ID);
            coachTableAdapter.Insert(textBox7.Text, textBox8.Text, C_PH, T_ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int C_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out C_ID);
            coachTableAdapter.DeleteCoach(C_ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int P_PH;
            int.TryParse(textBox13.Text.ToString(), out P_PH);
            parentTableAdapter.Insert(textBox11.Text, textBox12.Text, P_PH, textBox14.Text);
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int P_ID;
            int.TryParse(comboBox4.SelectedValue.ToString(), out P_ID);
            parentTableAdapter.DeleteParent(P_ID);
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int PL_ID;
            int PR_ID;
            int EN_ID;
            

            int.TryParse(comboBox6.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox7.SelectedValue.ToString(), out PR_ID);
            EN_ID = PR_ID * 1000 + PL_ID;
            enrollTableAdapter.Insert(EN_ID,PL_ID, PR_ID) ;
            this.enrollTableAdapter.Fill(this.dataSet11.Enroll);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int EN_ID;
            int.TryParse(comboBox5.SelectedValue.ToString(), out EN_ID);
            enrollTableAdapter.DeleteEnroll(EN_ID);
            this.enrollTableAdapter.Fill(this.dataSet12.Enroll);
        }
        //UPDATE FOR TEAM
        private void button2_Click(object sender, EventArgs e)
        {
            int UPD;
            int.TryParse(comboBox1.SelectedValue.ToString(), out UPD);
            teamTableAdapter.UpdateQuery(textBox1.Text,textBox2.Text, UPD,UPD);
            this.teamTableAdapter.Fill(this.dataSet1.Team);


        }
        //UPDATE FOR PLAYER 
        private void button5_Click(object sender, EventArgs e)
        {
            int PL_AGE;
            int UPD;
            int T_ID;
            int.TryParse(comboBox8.SelectedValue.ToString(), out T_ID);
            int.TryParse(textBox5.Text.ToString(), out PL_AGE);
            int.TryParse(comboBox2.SelectedValue.ToString(), out UPD);
            playerTableAdapter.UpdateQuery(textBox3.Text, textBox4.Text, PL_AGE,T_ID, UPD, UPD);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }
        //UPDATE FOR COACH
        private void button8_Click(object sender, EventArgs e)
        {
            int UPD;
            int T_ID;
            int C_PH;
            int.TryParse(comboBox9.SelectedValue.ToString(), out T_ID);
            int.TryParse(comboBox2.SelectedValue.ToString(), out UPD);
            int.TryParse(textBox9.Text.ToString(), out C_PH);
            coachTableAdapter.MYupdate(textBox7.Text, textBox8.Text, C_PH, T_ID, UPD,UPD);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }
        //UPDATE FOR PARENT 
        private void button10_Click(object sender, EventArgs e)
        {
            int UPD;
            int.TryParse(comboBox4.SelectedValue.ToString(), out UPD);
            int P_PH;
            int.TryParse(textBox13.Text.ToString(), out P_PH);
            parentTableAdapter.UpdateQuery(textBox11.Text, textBox12.Text,P_PH ,textBox14.Text,UPD,UPD);
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
        }

        
    }
}
