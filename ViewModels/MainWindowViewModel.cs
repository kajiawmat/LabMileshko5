using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;

namespace LabMilesko5.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string text = "";
        string text2 = "";
        string compold = "";
        string compnew = "";

        public string InputText
        {
            get { return text; }

            set
            {
                //Почему-то отказывается работать
                //var comptask = MyFileStream.CompText(value,compnew);
                this.RaiseAndSetIfChanged(ref text, value);
                //OutputText = await comptask;
                OutputText = MyFileStream.CompText(value, compnew);
            }
        }
        public string OutputText
        {
            get { return text2; }

            set
            {
                this.RaiseAndSetIfChanged(ref text2, value);
            }
        }

        string pathin = "";

        public string SetPath
        {
            get => pathin;

            set
            {
                //var readtask = MyFileStream.ReadFile(value);
                string pathin_old = (string)pathin.Clone();
                this.RaiseAndSetIfChanged(ref pathin, value);
                if (String.Compare(pathin_old, value) != 0) /*TextIn = await readtask;*/ InputText= MyFileStream.ReadFile(value);
            }
        }

        string pathout = "";

        public string GetPath
        {
            get => pathout;

            set
            {
                //var savetask = MyFileStream.SaveFile(value,text2);
                string pathout_old = (string)pathout.Clone();
                this.RaiseAndSetIfChanged(ref pathout, value);
                if (String.Compare(pathout_old, value) != 0) /*await savetask;*/ MyFileStream.SaveFile(value, text2);
            }
        }


        public string CompOld
        {
            get => compold;

            set
            {
                this.RaiseAndSetIfChanged(ref compold, value);
            }
        }

        public string CompNew
        {
            get => compnew;

            set
            {
                //var comptask = MyFileStream.CompText(text,value);
                this.RaiseAndSetIfChanged(ref compnew, value);
                //OutputText = await comptask;
                OutputText= MyFileStream.CompText(text, value);
            }
        }
    }
}
