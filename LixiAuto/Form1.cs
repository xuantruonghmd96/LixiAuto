using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace LixiAuto
{
    public partial class Form1 : Form
    {
        int _lixiClickAddX = 130, _lixiClickAddY = 60, _lixiClickAddNext = -100, _count = 0;
        int _padLeft = 1300, _padTop = 100;
        int hue = 7, saturation = 30, brightness = 40;
        public Form1()
        {
            InitializeComponent();
            numHue.Value = hue;
            numSaturation.Value = saturation;
            numBrightness.Value = brightness;
        }

        private async void btnStart_Click_2(object sender, EventArgs e)
        {
            LblCount.Text = _count.ToString();
            btnStart.Enabled = false;
            hue = (int)numHue.Value; saturation = (int)numSaturation.Value; brightness = (int)numBrightness.Value;
            BitmapDetectTool.hue = hue;
            BitmapDetectTool.saturation = saturation;
            BitmapDetectTool.brightness = brightness;

            using (var lixiImage = new Bitmap(tbxScreenSavePath.Text + "\\resources\\" + "lixi2.png"))
            {
                do
                {
                    using (var captureBitmap = ScreenCaptureTool.CaptureMyScreen(_padLeft, _padTop))
                    {
                        var lixiPoint = BitmapDetectTool.Find(captureBitmap, lixiImage);
                        if (lixiPoint != null)
                        {
                            await Task.Delay(400);
                            _count++;
                            LblCount.Text = _count.ToString();
                                int clickX = lixiPoint.Value.X + _padLeft + _lixiClickAddX;
                                int clickY = lixiPoint.Value.Y + _padTop + _lixiClickAddY;
                                ClickOnPointTool.ClickOnPoint(this.Handle, new Point(clickX, clickY));
                                await Task.Delay(400);
                                ClickOnPointTool.ClickOnPoint(this.Handle, new Point(clickX, clickY));

                            await Task.Delay(500);
                            Random rand = new Random();
                            using (var screenSaveBitmap = ScreenCaptureTool.CaptureMyScreen(Screen.PrimaryScreen.Bounds.Width / 2 + rand.Next(200), 100 + rand.Next(200), rand.Next(200), rand.Next(400)))
                            {
                                //Saving the Image File (I am here Saving it in My E drive).
                                string savePath = tbxScreenSavePath.Text + "\\" + DateTime.Now.ToString("yyyyMMdd");
                                Directory.CreateDirectory(savePath);
                                screenSaveBitmap.Save(savePath + "\\" + DateTime.Now.ToString("yyyyMMdd_HHmmssff") + ".jpg", ImageFormat.Jpeg);

                                await ClickLixiOk();
                            }
                            await ClickF5();
                            await Task.Delay(200);
                            await ClickKhungChat();
                        }
                    }
                    await Task.Delay(200);
                } while (true);
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            LblCount.Text = _count.ToString();
            btnStart.Enabled = false;
            hue = (int)numHue.Value; saturation = (int)numSaturation.Value; brightness = (int)numBrightness.Value;
            BitmapDetectTool.hue = hue;
            BitmapDetectTool.saturation = saturation;
            BitmapDetectTool.brightness = brightness;

            using (var lixiImage = new Bitmap(tbxScreenSavePath.Text + "\\resources\\" + "lixi1.png"))
            {
                do
                {
                    using (var captureBitmap = ScreenCaptureTool.CaptureMyScreen(_padLeft, _padTop))
                    {
                        var lixiPoint = BitmapDetectTool.Find(captureBitmap, lixiImage);
                        if (lixiPoint != null)
                        {
                            await ClickDungManHinh();
                            await Task.Delay(400);
                            _count++;
                            LblCount.Text = _count.ToString();
                            using (var captureLixi = ScreenCaptureTool.CaptureMyScreen(_padLeft, _padTop))
                            {
                                lixiPoint = BitmapDetectTool.Find(captureLixi, lixiImage)!;
                                int clickX = lixiPoint.Value.X + _padLeft + _lixiClickAddX;
                                int clickY = lixiPoint.Value.Y + _padTop + _lixiClickAddY;
                                ClickOnPointTool.ClickOnPoint(this.Handle, new Point(clickX, clickY));
                                await Task.Delay(200);
                                ClickOnPointTool.ClickOnPoint(this.Handle, new Point(clickX, clickY));
                                //ClickOnPointTool.ClickOnPoint(this.Handle, new Point(clickX, clickY + _lixiClickAddNext + _lixiClickAddNext));
                                //await Task.Delay(100);
                            }

                            await Task.Delay(500);
                            Random rand = new Random();
                            using (var screenSaveBitmap = ScreenCaptureTool.CaptureMyScreen(Screen.PrimaryScreen.Bounds.Width / 2 + rand.Next(200), 100 + rand.Next(200), rand.Next(200), rand.Next(400)))
                            {
                                //Saving the Image File (I am here Saving it in My E drive).
                                string savePath = tbxScreenSavePath.Text + "\\" + DateTime.Now.ToString("yyyyMMdd");
                                Directory.CreateDirectory(savePath);
                                screenSaveBitmap.Save(savePath + "\\" + DateTime.Now.ToString("yyyyMMdd_HHmmssff") + ".jpg", ImageFormat.Jpeg);

                                await ClickLixiOk();
                            }
                            await ClickF5();
                            await Task.Delay(200);
                            await ClickKhungChat();
                        }
                    }
                    await Task.Delay(200);
                } while (true);
            }
        }

        private async Task ClickF5()
        {
            await Task.Delay(200);
            ClickOnPointTool.ClickOnPoint(this.Handle, new Point(1078, 80));
            await Task.Delay(500);
        }

        private async Task ClickKhungChat()
        {
            ClickOnPointTool.ClickOnPoint(this.Handle, new Point(1755, 306));
        }

        private async Task ClickDungManHinh()
        {
            ClickOnPointTool.ClickOnPoint(this.Handle, new Point(1755, 206));
        }

        private async Task ClickXoaManHinh()
        {
            await Task.Delay(200);
            ClickOnPointTool.ClickOnPoint(this.Handle, new Point(1799, 204));
        }

        private async Task ClickLixiOk()
        {
            await Task.Delay(200);
            ClickOnPointTool.ClickOnPoint(this.Handle, new Point(1441, 611));
        }
    }

    public class BitmapDetectTool
    {
        public static Point? Find1(Bitmap haystack, Bitmap needle)
        {
            if (null == haystack || null == needle)
            {
                return null;
            }
            if (haystack.Width < needle.Width || haystack.Height < needle.Height)
            {
                return null;
            }

            var haystackArray = GetPixelArray(haystack);
            var needleArray = GetPixelArray(needle);

            foreach (var firstLineMatchPoint in FindMatch(haystackArray.Take(haystack.Height - needle.Height).ToList(), needleArray[0]))
            {
                if (IsNeedlePresentAtLocation(haystackArray, needleArray, firstLineMatchPoint, 1))
                {
                    return firstLineMatchPoint;
                }
            }

            return null;
        }

        private static int[][] GetPixelArray(Bitmap bitmap)
        {
            var result = new int[bitmap.Height][];
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            for (int y = 0; y < bitmap.Height; ++y)
            {
                result[y] = new int[bitmap.Width];
                Marshal.Copy(bitmapData.Scan0 + y * bitmapData.Stride, result[y], 0, result[y].Length);
            }

            bitmap.UnlockBits(bitmapData);

            return result;
        }

        private static IEnumerable<Point> FindMatch(List<int[]> haystackLines, int[] needleLine)
        {
            var y = 0;
            for (int i = 850; i < haystackLines.Count(); i++)
            {
                for (int x = 1489, n = haystackLines[i].Length - needleLine.Length; x < n; ++x)
                {
                    if (ContainSameElements(haystackLines[i], x, needleLine, 0, needleLine.Length))
                    {
                        yield return new Point(x, y);
                    }
                }
                y += 1;
            }
        }

        private static bool ContainSameElements(int[] first, int firstStart, int[] second, int secondStart, int length)
        {
            for (int i = 0; i < length; ++i)
            {
                if (first[i + firstStart] != second[i + secondStart])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsNeedlePresentAtLocation(int[][] haystack, int[][] needle, Point point, int alreadyVerified)
        {
            //we already know that "alreadyVerified" lines already match, so skip them
            for (int y = alreadyVerified; y < needle.Length; ++y)
            {
                if (!ContainSameElements(haystack[y + point.Y], point.X, needle[y], 0, needle[y].Length))
                {
                    return false;
                }
            }
            return true;
        }

        public static int hue, saturation, brightness;
        internal static Point? Find(Bitmap picture, Bitmap objPicture)
        {
            if (picture.Width < objPicture.Width || picture.Height < objPicture.Height)
            {
                return null;
            }

            for (int i = 0; i < picture.Height; i++)
            {
                for (int j = 0; j < picture.Width; j++)
                {
                    if (MatchLine(picture, j, i, objPicture, 0, 0))
                    {
                        int k;
                        for (k = 1; k < objPicture.Height; k++)
                        {
                            if (!MatchLine(picture, j, i+k, objPicture, 0, k))
                            {
                                break;
                            }
                        }
                        if (k >= objPicture.Height)
                        {
                            return new Point(j, i);
                        }
                    }
                }
            }
            return null;
        }

        private static bool MatchLine(Bitmap picture, int x, int y, Bitmap objPicture, int u, int v)
        {
            for (int i = 0; i < objPicture.Width-u; i++)
            {
                if (!SamePixcel(objPicture.GetPixel(i+u, v), picture.GetPixel(i+x, y)))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool SamePixcel(Color color1, Color color2)
        {
            var hueCount = Math.Abs(color1.GetHue() - color2.GetHue());
            return (
                    Math.Min(hueCount, 360-hueCount) <= hue
                    && Math.Abs(color1.GetSaturation() - color2.GetSaturation())*100 <= saturation
                    && Math.Abs(color1.GetBrightness() - color2.GetBrightness())*100 <= brightness
                );
        }
    }

    public class ScreenCaptureTool
    {
        public static Bitmap CaptureMyScreen(int padLeft = 0, int padTop = 0, int padRight = 0, int padDown = 0)
        {
            //Creating a new Bitmap object
            Bitmap captureBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width - padLeft - padRight + 2, Screen.PrimaryScreen.Bounds.Height - padTop - padDown + 2, PixelFormat.Format32bppArgb);
            //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
            //Creating a Rectangle object which will
            //capture our Current Screen
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            //Creating a New Graphics Object
            using (Graphics captureGraphics = Graphics.FromImage(captureBitmap))
            {
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(padLeft, padTop, 0, 0, new Size(captureRectangle.Width - padLeft - padRight, captureRectangle.Height - padTop - padDown));
            }
            return captureBitmap;
        }
    }

    public class ClickOnPointTool
    {

        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

#pragma warning restore 649


        public static void ClickOnPoint(IntPtr wndHandle, Point clientPoint)
        {
            var oldPos = Cursor.Position;

            /// get screen coordinates
            //ClientToScreen(wndHandle, ref clientPoint);

            /// set cursor on coords, and press mouse
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);

            var inputMouseDown = new INPUT();
            inputMouseDown.Type = 0; /// input type mouse
            inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

            var inputMouseUp = new INPUT();
            inputMouseUp.Type = 0; /// input type mouse
            inputMouseUp.Data.Mouse.Flags = 0x0004; /// lzzzzzzzzzzzzeft button up

            var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            /// return mouse 
            //Cursor.Position = oldPos;
        }

    }

}