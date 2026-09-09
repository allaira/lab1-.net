using System;

namespace lab1
{
    public class OneDArray
    {
        private string[] arr;
        private int length;


        public bool hasError = false;
        public int Length => length;

        public OneDArray()
        {
            length = 5;
            arr = new string[5] { "Шевченко", "Франко", "Костенко", "Українка", "Сковорода" };
        }

        public OneDArray(int size)
        {
            length = size > 0 ? size : 5;
            arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = $"Прізвище_{i + 1}";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < length)
                {
                    hasError = false;
                    return arr[index];
                }
                hasError = true;
                return "Помилка: індекс поза межами масиву!";
            }
            set
            {
                if (index >= 0 && index < length)
                {
                    hasError = false;
                    arr[index] = value;
                }
                else
                {
                    hasError = true;
                }
            }
        }

        public string GetElement(int index)
        {
            return this[index];
        }

        // Вивід усього масиву стовпчиком
        public string[] GetReversed()
        {
            string[] reversed = new string[length];
            for (int i = 0; i < length; i++)
            {
                reversed[i] = arr[length - 1 - i];
            }
            return reversed;
        }

        public string[] GetAll()
        {
            return arr;
        }
    }
}