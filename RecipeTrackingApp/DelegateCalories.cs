using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTrackingApp
{
    public delegate void SerialData(double dataOut);
    internal class DataInPort
    {
        //Creating A listener
        public event SerialData SerialDataSend;

        /// <param name="dataOut"></param>
        public virtual void OnDataSend(double dataOut)
        {
            SerialDataSend?.Invoke(dataOut);
        }
        public DataInPort() { }

        public void DataIn(double myData)
        {
            //Checking if calories exceeds 300
            if (myData > 300)
            {
                this.OnDataSend(myData);
            }

        }
    }
}
