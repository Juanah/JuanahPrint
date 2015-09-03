using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanahPrint.FilamentCalculator
{
    /// <summary>
    /// 
    /// </summary>
    internal static class FilaCalc
    {
        static List<float> _values = new List<float>();
        public static float Diameter { get; private set; }

        public static void SetDiameter(float diameter)
        {
            Diameter = diameter;
            _values = new List<float>();
        }

        public static void AddMesurement(float value)
        {
            _values.Add(value);
        }

        public static void Reset()
        {
            _values.Clear();
        }

        public static FilaCalcResult Calculate()
        {
            int messurements = _values.Count();
            double total = 0.0;

            foreach (var value in _values)
            {
                total += value;
            }
            FilaCalcResult result = new FilaCalcResult((float)(total / messurements), messurements);
            return result;
        }

    }

    internal class FilaCalcResult
    {

        public FilaCalcResult(float averrage,int messurements)
        {
            this.Averrage = averrage;
            this.Messurements = messurements;
        }

        public float Averrage { get; private set; }
        public int Messurements { get; private set; }
    }
}
