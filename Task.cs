using System.Windows.Forms;
using rpg;

public class Task
{

    public static int p = 0;

    public static Player.Status player_last_status = Player.Status.WALK;
    public static void story(int i)
    {
        if (Player.status != Player.Status.TASK)
            player_last_status = Player.status;
        Player.status = Player.Status.TASK;

        DialogResult r1;
        if (i == 0) {

            if (p == 0)
            {
                Message.showtip("一只破鞋");
                block();
            }
            else if (p == 1)
            {
                Message.showtip("捡起破鞋");
                block();
                Form1.npc[0].x = -100;
                p = 2;
            }
            else if (p == 2)
            {
            }
        }
        if (i == 1) {
            if (p == 0)
            {
                Player.status = Player.Status.WALK;
                Fight.start(new int[] { 0, 0, -1 }, "fight/f_scene.png", 1,
                0, 1, 1, 100);
                return;
                /*
;
                
                Message.show("陌生人", "年轻人，我看你智慧超群，天资聪慧，是百年难得一见的游戏奇才，去，把下面那只鞋给我捡回来。", "face4_2.png", Message.Face.RIGHT);
                block();
                Message.show("主角", "真是个没礼貌的年轻人，不理你了。", "face2_1.png", Message.Face.LEFT);
                block();
                Message.show("陌生人", "拜托，年轻人，好好配合一下，不然剧情怎么发展？", "face4_2.png", Message.Face.RIGHT);
                block();
                Message.show("主角", "好吧，算我倒霉，遇到怪人了。", "face2_1.png", Message.Face.LEFT);
                block();
                p = 1;
                */
            }
            else if (p == 1)
            {
                Message.show("陌生人", "还不快去捡鞋。", "face4_2.png", Message.Face.RIGHT);
                block();
            }
            else if (p == 2)
            {
                Message.show("陌生人", "孺子可教也。我这里有一本奇书，就此传授于你。你要下苦功钻研这部书。钻研透了，以后可以做帝王的老师。十年后必定有大成就。", "face4_2.png", Message.Face.RIGHT);
                block();
                Message.showtip("获得《罗培羽书》");
                block();
                Item.add_item(5, 1);
                p = 3;
            }
            else if (p == 3)
            {
                Message.show("陌生人", "孺子可教也。", "face4_2.png", Message.Face.RIGHT);
                block();
            }
        }
        if (i == 2) { Map.change_map(Form1.map, Form1.player, Form1.npc, 1, 955, 550, 2); }/* Form1.music_player); }*/
        if (i == 3) { Map.change_map(Form1.map, Form1.player, Form1.npc, 0, 45, 500, 3); }/* Form1.music_player); }*/
        if (i == 4) { Form1.npc[4].play_anm(0); }
        if (i == 5) { r1 = MessageBox.Show("我会走路"); }

        Player.status = player_last_status;
    }




    public static void block()
    {
        while (Player.status == Player.Status.PANEL) 
             Application.DoEvents();
    }


    


}