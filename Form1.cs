using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rpg
{


    public partial class Form1 : Form
    {

        public static Player[] player = new Player[3];
        public static Map[] map = new Map[2];
        public static Npc[] npc = new Npc[6];

        //public static WMPLib.WindowsMediaPlayer music_player = new WMPLib.WindowsMediaPlayer();


        public Bitmap mc_nomal;
        public Bitmap mc_event;
        public int mc_mod = 0;//0-nomal 1-event

        public Form1()
        {
            InitializeComponent();
        }


        private void Draw()
        {
            
            //创建在pictureBox1上的图像g1
            Graphics g1 = stage.CreateGraphics();
            // 将图像画在内存上，并使g为pictureBox1上的图像
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            BufferedGraphics myBuffer = currentContext.Allocate(g1, this.DisplayRectangle);
            Graphics g = myBuffer.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // 自定义绘图
            if (Fight.fighting == 0)
                Map.draw(map, player, npc, g, new Rectangle(0, 0, stage.Width, stage.Height));
            else
                Fight.draw(g);

            if (Panel.panel != null)
                Panel.draw(g);


            draw_mouse(g);
            // 显示图像并释放资源
            myBuffer.Render();
            myBuffer.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            Player.key_ctrl(player, map, npc, e);
            if (Panel.panel != null)
                 Panel.key_ctrl(e);

        }


        public void tryevent()
        {
            MessageBox.Show("成功");
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            //光标
            mc_nomal = new Bitmap(@"mc_1.png");
            mc_nomal.SetResolution(96, 96);
            mc_event = new Bitmap(@"mc_2.png");
            mc_nomal.SetResolution(96, 96);
            Title.init();
            Message.init();
            StatusMenu.init();
            Shop.init();
            Define.define(player, npc, map);
            Fight.init();


            Map.change_map(Form1.map, Form1.player, Form1.npc, 0, 800, 400, 1); /*Form1.music_player);*/
            
            //Title.show();
            this.Show();
            

        }

        private void stage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Player.key_ctrl_up(player, e);
            
        }


        private void draw_mouse(Graphics g)
        {
            Point showpoint = stage.PointToClient(Cursor.Position);
            if(mc_mod == 0)
                g.DrawImage(mc_nomal, showpoint.X, showpoint.Y);
            else
                g.DrawImage(mc_event, showpoint.X, showpoint.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player.timer_logic(player, map);

            for (int i = 0; i < npc.Length; i++)
            {
                if (npc[i] == null)
                    continue;
                if (npc[i].map != Map.current_map)
                    continue;

                npc[i].timer_logic(map);
            }
            Draw();
        }

        private void stage_MouseMove(object sender, MouseEventArgs e)
        {
            if (Panel.panel != null)
                Panel.mouse_move(e);
            mc_mod = Npc.check_mouse_collision(map, player,npc, new Rectangle(0, 0, stage.Width, stage.Height), e);
        }

        private void stage_MouseClick(object sender, MouseEventArgs e)
        {
            
            Player.mouse_click(map, player, new Rectangle(0, 0, stage.Width, stage.Height), e);
            Npc.mouse_click(map, player, npc, new Rectangle(0, 0, stage.Width, stage.Height), e);
            if (Panel.panel != null)
                Panel.mouse_click(e);
        }

        private void stage_MouseDown(object sender, MouseEventArgs e)
        {
           
           
        }

        private void stage_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void stage_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }


    }
}
