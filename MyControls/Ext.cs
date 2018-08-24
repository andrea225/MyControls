namespace HYL
{
    using System;
    using System.Windows.Forms;

    public static class Ext
    {
        public static void InvokeAction(this Control c, Action action)
        {
            if (c.InvokeRequired)
            {
                c.Invoke(action);
            }
            else
            {
                action.Invoke();
            }
        }
    }
}