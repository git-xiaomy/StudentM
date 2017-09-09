using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Threading;

namespace StudentM
{
    //该类实现语音播报功能
    class Voice
    {
        private static SpeechSynthesizer synth;

        //初始化
        public static void init() {
            synth = new SpeechSynthesizer();
        }
        //对外可调用
        public static void said(String s) {
            Thread t = new Thread(new ParameterizedThreadStart(say));
            t.Start(s);
        }

        //语音播报线程，防止卡UI
        private static void say(Object o) {
            synth.Speak(o.ToString());
        }
    }
}
