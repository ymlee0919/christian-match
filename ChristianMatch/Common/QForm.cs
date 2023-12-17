using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common
{
    public abstract class QForm : Form
    {
        public QForm()
            : base()
        {
        }

        public abstract void Restart();

        public abstract void SetMaxTime(int maxSecondsTime);

        public abstract void SetTheQuestion(Common.Question q);
    }
}
