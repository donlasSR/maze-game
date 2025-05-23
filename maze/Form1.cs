using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);// ตั้งค่าให้ฟอร์มนี้สามารถรับการกดปุ่มคีย์บอร์ดได้
            this.KeyPreview = true; // ตั้งค่าให้ฟอร์มนี้สามารถรับการกดปุ่มคีย์บอร์ดได้ก่อนที่คอนโทรลอื่นๆ จะได้รับการกดปุ่ม
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {
            player.Visible = true; // ทำให้ player มองเห็นได้
            player.Enabled = true; // ทำให้ player สามารถใช้งานได้
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)//สำหรับตั้งค่าให้ฟอร์มนี้สามารถรับการกดปุ่มคีย์บอร์ดได้
        {
            
            {
                int moveAmount = 5; // จำนวนที่เคลื่อนที่ในแต่ละครั้ง
                int newX = player.Location.X;
                int newY = player.Location.Y;


                if (e.KeyCode == Keys.W)
                {
                    newY -= moveAmount; // เคลื่อนที่ขึ้น
                }
                else if (e.KeyCode == Keys.S)
                {
                    newY += moveAmount; // เคลื่อนที่ลง
                }
                else if (e.KeyCode == Keys.A)
                {
                    newX -= moveAmount; // เคลื่อนที่ไปทางซ้าย
                }
                else if (e.KeyCode == Keys.D)
                {
                    newX += moveAmount; // เคลื่อนที่ไปทางขวา
                }

                
                Rectangle featureboard = new Rectangle(newX,newY,player.Width,player.Height);// สร้าง Rectangle สำหรับ player โดยใช้ตำแหน่งใหม่ที่คำนวณได

                bool collinsion = false; // ตัวแปรสำหรับเช็คการชน
                foreach (Control control in mazearea.Controls)// วนลูปใน maze area
                {
                    if (control is Label && control.BackColor == Color.Black)/*เช็คว่า control เป็น Label และมีสีดำ*/
                    {
                        if (featureboard.IntersectsWith(control.Bounds))//เช็คว่า player ชนกับ Label สีดำ
                        {
                            collinsion = true; // ตั้งค่าให้ชน
                            break;
                        }
                    }
                }

                if (!collinsion) // ถ้าไม่ชน
                {
                    player.Location = new System.Drawing.Point(newX, newY); // เคลื่อนที่ player
                }

                if (player.Bounds.IntersectsWith(goal.Bounds))//เช็คว่า player ถึง goal แล้วยัง
                {
                    MessageBox.Show("You Win!"); // แสดงข้อความเมื่อ player ชนะ
                    System.Windows.Forms.Application.Exit(); // ปิดโปรแกรม
                }

            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true; 
            player.Location = new System.Drawing.Point(20, 20);
            
        }
    }
}
