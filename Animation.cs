using System.Drawing;

public class Animation
{
    public static long RATE = 100; 

    public string bitmap_path;
    public Bitmap bitmap;
    public int row = 1;
    public int col = 1;
    public int max_frame = 1;
    public int anm_rate;


    //获取图片
    public Bitmap get_bitmap(int frame)
    {
        if (bitmap == null)
            return null;

        if (frame >= max_frame)
            return null;

        //定义区域
        Rectangle rect = new Rectangle(
            bitmap.Width / row * (frame % row),
            bitmap.Height / col * (frame / row),
            bitmap.Width / row,
            bitmap.Height / col);
        //return
        return bitmap.Clone(rect, bitmap.PixelFormat);
    }

    //加载
    public void load()
    {
        if (bitmap_path != null && bitmap_path != "")
        {
            bitmap = new Bitmap(bitmap_path);
            bitmap.SetResolution(96, 96);
        }
    }
    public void unload()
    {
        if (bitmap != null)
        {
            bitmap = null;
        }
    }


    public void draw(Graphics g, int frame, int x, int y )
    {
        Bitmap bitmap = get_bitmap(frame / anm_rate);
        if (bitmap == null)
            return ;
 
        g.DrawImage(bitmap, x,y);


    }
}