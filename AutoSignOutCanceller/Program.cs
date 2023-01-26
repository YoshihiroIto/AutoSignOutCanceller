using System.Runtime.InteropServices;

[DllImport("user32.dll", CharSet = CharSet.Auto)]
static extern void keybd_event(byte bVirtualKey, byte bScan, uint dwFlags, nint dwExtraInfo);

const byte VK_F24 = 0x87;
const uint KEYEVENTF_KEYUP = 2;

while (true)
{
    await Task.Delay(TimeSpan.FromSeconds(Random.Shared.Next(60 * 10, 60 * 11)));

    keybd_event(VK_F24, 0, 0, nint.Zero);
    await Task.Delay(TimeSpan.FromMilliseconds(Random.Shared.Next(50)));
    keybd_event(VK_F24, 0, KEYEVENTF_KEYUP, nint.Zero);

    Console.WriteLine("AutoSignOutCanceller:update");
}