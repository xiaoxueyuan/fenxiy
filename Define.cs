﻿using System.Drawing;


public static class Define
{
    public static void define(Player[] player, Npc[] npc, Map[] map)
    {
        Player.current_player = 0;
        //player define
        player[0] = new Player();
        player[0].bitmap = new Bitmap(@"r1.png");
        player[0].bitmap.SetResolution(96, 96);
        player[0].is_active = 1;
        player[0].status_bitmap = new Bitmap(@"item/face1.png");
        player[0].status_bitmap.SetResolution(96, 96);

        player[1] = new Player();
        player[1].bitmap = new Bitmap(@"r2.png");
        player[1].bitmap.SetResolution(96, 96);
        player[1].is_active = 1;
        player[1].status_bitmap = new Bitmap(@"item/face2.png");
        player[1].status_bitmap.SetResolution(96, 96);

        player[2] = new Player();
        player[2].bitmap = new Bitmap(@"r3.png");
        player[2].bitmap.SetResolution(96, 96);
        player[2].is_active = 1;
        player[2].status_bitmap = new Bitmap(@"item/face3.png");
        player[2].status_bitmap.SetResolution(96, 96);
        //npc define
        npc[0] = new Npc();
        npc[0].map = 0;
        npc[0].x = 600;
        npc[0].y = 780;
        npc[0].y_offset = -50;
        npc[0].mc_xoffset = 0;
        npc[0].mc_yoffset = 0;
        npc[0].mc_w = 90;
        npc[0].mc_h = 50;
        npc[0].bitmap_path = "npc_shoe.png";
        npc[0].collision_type = Npc.Collosion_type.KEY;

        npc[1] = new Npc();
        npc[1].map = 0;
        npc[1].x = 800;
        npc[1].y = 280;
        npc[1].bitmap_path = "npc2.png";
        npc[1].collision_type = Npc.Collosion_type.KEY;

        npc[2] = new Npc();
        npc[2].map = 0;
        npc[2].x = 20;
        npc[2].y = 600;
        npc[2].region_x = 40;
        npc[2].region_y = 400;
        npc[2].collision_type = Npc.Collosion_type.ENTER;

        npc[3] = new Npc();
        npc[3].map = 1;
        npc[3].x = 980;
        npc[3].y = 600;
        npc[3].region_x = 40;
        npc[3].region_y = 400;
        npc[3].collision_type = Npc.Collosion_type.ENTER;

        npc[4] = new Npc();
        npc[4].map = 1;
        npc[4].x = 700;
        npc[4].y = 350;
        npc[4].bitmap_path = "npc3.png";
        npc[4].collision_type = Npc.Collosion_type.KEY;
        Animation npc4anm1 = new Animation();
        npc4anm1.bitmap_path = "anm1.png";
        npc4anm1.row = 2;
        npc4anm1.col = 2;
        npc4anm1.max_frame = 3;
        npc4anm1.anm_rate = 4;
        npc[4].anm = new Animation[1];
        npc[4].anm[0] = npc4anm1;

        npc[5] = new Npc();
        npc[5].map = 1;
        npc[5].x = 450;
        npc[5].y = 300;
        npc[5].bitmap_path = "npc4.png";
        npc[5].collision_type = Npc.Collosion_type.KEY;
        npc[5].npc_type = Npc.Npc_type.CHARACTER;
        npc[5].idle_walk_direction = Comm.Direction.LEFT;
        npc[5].idle_walk_time = 20;

        //map define
        map[0] = new Map();
        map[0].bitmap_path = "map1.png";
        map[0].shade_path = "map1_shade.png";
        map[0].block_path = "map1_block.png";
        map[0].music = "1.mp3";
        map[0].back_path = "map1_back.png";

        map[1] = new Map();
        map[1].bitmap_path = "map2.png";
        map[1].shade_path = "map2_shade.png";
        map[1].block_path = "map2_block.png";
        map[1].music = "2.mp3";

        //item
        Item.item = new Item[6];
        Item.item[0] = new Item();
        Item.item[0].set("红药水", "恢复少量hp", "item/item1.png", 1,
            30, 0, 0, 0, 0);
        Item.item[0].cost = 30;

        Item.item[0].use_event += new Item.Use_event(Item.add_hp);

        Item.item[1] = new Item();
        Item.item[1].set("蓝药水", "恢复少量mp", "item/item2.png", 1,
            30, 0, 0, 0, 0);
        Item.item[1].use_event += new Item.Use_event(Item.add_mp);
        
        Item.item[2] = new Item();
        Item.item[2].set("短剑", "一把钢质短剑", "item/item3.png", 1,
            1, 10, 0, 0, 5);
        Item.item[2].use_event += new Item.Use_event(Item.equip);
        
        Item.item[3] = new Item();
        Item.item[3].set("斧头", "传说这是一把能够劈开阴\n气的斧头，但无人亲眼见\n过它的威力", "item/item4.png", 1,
            1, 3, 0, 0, 50);
        Item.item[3].use_event += new Item.Use_event(Item.equip);
        
        Item.item[4] = new Item();
        Item.item[4].set("钢盾", "刚质盾牌，没有矛可以穿\n破它", "item/item5.png", 1,
            2, 0, 20, 5, 0);
        Item.item[4].use_event += new Item.Use_event(Item.equip);
        
        Item.item[5] = new Item();
        Item.item[5].set("罗培羽书", "一本游记，记录世间\n奇事，可打开阅览", "item/item6.png", 0,
            30, 0, 0, 0, 0);
        Item.item[5].use_event += new Item.Use_event(Item.lpybook);

        Item.add_item(0, 3);
        Item.add_item(1, 3);
        Item.add_item(2, 1);
        Item.add_item(3, 1);
        Item.add_item(4, 1);
        //Item.add_item(5, 1);
        
        //skill
        Skill.skill = new Skill[2];
        Skill.skill[0] = new Skill();
        Skill.skill[0].set("治疗术", "恢复少量hp\nmp:20", "item/skill2.png", 20,
            20, 0, 0, 0, 0);
        Skill.skill[0].use_event += new Skill.Use_event(Skill.add_hp);

        Skill.skill[1] = new Skill();
        Skill.skill[1].set("黑洞漩涡", "攻击型技能，将敌人\n吸入漩涡\nmp:20", "item/skill1.png",20,
            0, 0, 0, 0 ,0);
        Skill.skill[1].use_event += new Skill.Use_event(Skill.add_hp);

        Skill.learn_skill(0, 0, 1);
        Skill.learn_skill(0, 1, 1);
        Skill.learn_skill(1, 0, 1);

        //战斗定义
        Animation anm_att = new Animation();
        anm_att.bitmap_path = "fight/anm_att.png";
        anm_att.row = 4;
        anm_att.col = 2;
        anm_att.max_frame = 5;
        anm_att.anm_rate = 1;

        Animation anm_item = new Animation();
        anm_item.bitmap_path = "fight/anm_item.png";
        anm_item.row = 4;
        anm_item.col = 1;
        anm_item.max_frame = 4;
        anm_item.anm_rate = 1;

        Animation anm_skill = new Animation();
        anm_skill.bitmap_path = "fight/anm_skill.png";
        anm_skill.row = 4;
        anm_skill.col = 1;
        anm_skill.max_frame = 4;
        anm_skill.anm_rate = 1;

        player[0].fset("主角1","fight/p1.png", -120, -120,
            "fight/fm_face1.png",
            anm_att, anm_item, anm_skill);

        player[1].fset("主角2", "fight/p2.png", -120, -120,
            "fight/fm_face2.png",
            anm_att, anm_item, anm_skill);

        player[2].fset("主角3", "fight/p3.png", -120, -120,
            "fight/fm_face3.png",
            anm_att, anm_item, anm_skill);


        //敌人设置
        Enemy.enemy = new Enemy[1];
        Enemy.enemy[0] = new Enemy();
        Enemy.enemy[0].set("老虎", "fight/enemy.png", -160, -120,
            100, 20, 10, 15, 10, anm_att, anm_skill,
            new int[]{-1, -1, 1, 1, 1});

        //fight_item
        Animation anm_item0 = new Animation();
        anm_item0.bitmap_path = "fight/anm_heal.png";
        anm_item0.row = 4;
        anm_item0.col = 1;
        anm_item0.max_frame = 4;
        anm_item0.anm_rate = 1;
        Item.item[0].fset(anm_item0, - 50, 20);

        Animation anm_item2 = new Animation();
        anm_item2.bitmap_path = "fight/anm_sword.png";
        anm_item2.row = 4;
        anm_item2.col = 2;
        anm_item2.max_frame = 6;
        anm_item2.anm_rate = 1;
        Item.item[2].fset(anm_item2, 50, 20);

        //fight_skill
        Animation anm_skill0 = new Animation();
        anm_skill0.bitmap_path = "fight/anm_heal.png";
        anm_skill0.row = 4;
        anm_skill0.col = 1;
        anm_skill0.max_frame = 4;
        anm_skill0.anm_rate = 1;
        Skill.skill[0].fset(anm_skill0, -50, 10);

        Animation anm_skill1 = new Animation();
        anm_skill1.bitmap_path = "fight/anm_dark.png";
        anm_skill1.row = 4;
        anm_skill1.col = 2;
        anm_skill1.max_frame = 6;
        anm_skill1.anm_rate = 1;
        Skill.skill[1].fset(anm_skill1, 60, 10);
    }


}