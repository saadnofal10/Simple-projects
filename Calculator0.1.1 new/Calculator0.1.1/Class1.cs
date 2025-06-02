using System;

namespace Calculator0._1._1
{
    internal class Calc
    {
        double[] numbers;
        char[] operations;
        int Num_of_num = 1;

        string tempText;
        bool dot = false;
        int index = 0;

        public string AddZero(string textbox, char c)
        {
            bool is_there_zero = true;
            textbox += c;
            if (index == 1 && textbox[textbox.Length - 1] == '0')
            {
                tempText = textbox;
                textbox = "";
                for (int i = 0; i < tempText.Length - 1; i++)
                {
                    textbox += tempText[i];
                }
            }
            else
            {
                index++;
            }
            return textbox;
        }// 0

        public string AddNumber(string textbox, char c)
        {
            textbox += c;
            if (index == 0) { }
            else if (textbox[textbox.Length - 2] == '0' && index == 1)//for make the first 0 any number
            {
                tempText = textbox;
                textbox = "";
                for (int i = 0; i < tempText.Length - 2; i++)
                {
                    textbox += tempText[i];
                }
                textbox += c;
            }
            index += 2;

            return textbox;
        }// 1 ~ 9

        public string AddDot(string textbox)
        {
            if (dot == false)
            {
                textbox += Convert.ToString(".");
                dot = true;
                index++;
            }
            tempText = textbox;
            if (textbox[textbox.Length - 1] == '.' && index == 1)
            {
                textbox = "";
                for (int i = 0; i < tempText.Length - 1; i++)
                {
                    textbox += tempText[i];
                }
                textbox += "0.";
                index++;
            }
            return textbox;
        }// .

        public string AddPercentChar(string textbox)
        {
            if (index != 0)
            {
                textbox += "%";
            }
            return textbox;
        }// %

        public string AddOperations(string textbox, char c)
        {
            try
            {
                char temp = textbox[textbox.Length - 1];
                if (temp == '+' || temp == '-' || temp == '×' || temp == '÷')
                {
                    tempText = textbox;
                    textbox = "";
                    for (int i = 0; i < tempText.Length - 1; i++)
                    {
                        textbox += tempText[i];
                    }
                    textbox += c;
                }
                else
                {
                    textbox += c;
                    index = 0;
                    Num_of_num++;
                }
                dot = false;
            }
            catch { }//if the user click and textbox.lenght = -1 
            return textbox;
        }// + - × ÷

        public string Clear()
        {
            dot = false;
            index = 0;
            Num_of_num = 1;
            return "";
        }

        public string Remove(string textbox)
        {
            index = 0;
            dot = false;
            tempText = textbox;
            textbox = "";
            for (int i = 0; i < tempText.Length - 1; i++)
            {
                textbox += tempText[i];
                if (textbox[i] > '0' && textbox[i] <= '9')
                    index += 2;
                else if (textbox[i] == '.')
                {
                    dot = true;
                    index++;
                }
                else
                {
                    dot = false;
                    index = 0;
                }
            }
            return textbox;
        }

        public void Calc_num_of_num(string textbox)
        {
            for (int i = 0; i < textbox.Length - 1; i++)
            {
                if (textbox[i] == '%' && textbox[i + 1] >= '0' && textbox[i + 1] <= '9')
                {
                    Num_of_num++;
                }
            }
        }

        public void SaveData(string g)
        {
            numbers = new double[Num_of_num];
            operations = new char[Num_of_num - 1];

            string ConvertToDouble = "";
            int j = 0;
            for (int i = 0; i < g.Length; i++)
            {
                try
                {
                    if ((g[i] >= '0' && g[i] <= '9') || g[i] == '.' || (i == 0 && g[i] == '-'))
                    {
                        ConvertToDouble += g[i];
                        numbers[j] = double.Parse(ConvertToDouble);
                    }
                    else if (g[i] == '%')
                    {
                        numbers[j] /= 100;
                        if (g[i + 1] > '0' && g[i + 1] <= '9')
                        {
                            operations[j] = '×';
                            j++;
                            ConvertToDouble = "";
                        }
                    }
                    else
                    {
                        operations[j] = g[i];
                        ConvertToDouble = "";
                        j++;
                        if (i == g.Length - 1 && (operations[j - 1] == '×' || operations[j - 1] == '÷'))// in case 5× or 6÷ 
                        {
                            numbers[j] = 1;
                        }
                    }
                }
                catch { }//for iegative number in the begging
            }
        }

        public string Show_Result(string textbox)
        {
            double Result = 0;
            int id = 0;
            if (Num_of_num == 1)
            {
                Result = numbers[0];
                return Result.ToString();
            }


            for (int i = 0; i < Num_of_num; i++)
            {
                try
                {
                    if (operations[i] == '×')
                    {
                        Result = numbers[i] * numbers[i + 1];
                        numbers[i] = Result;
                        operations[i] = ' ';
                        for (int k = i + 1; k < Num_of_num - 1; k++)
                        {
                            operations[k - 1] = operations[k];
                            numbers[k] = numbers[k + 1];
                        }
                        numbers[Num_of_num - 1] = 0;
                        Num_of_num--;
                        i--;
                    }
                    else if (operations[i] == '÷')
                    {
                        if (numbers[i + 1] == 0)
                        {
                            return "Cannot be divided by 0\n(Click C to countine)";
                        }
                        Result = numbers[i] / numbers[i + 1];
                        numbers[i] = Result;
                        operations[i] = ' ';
                        for (int k = i + 1; k < Num_of_num - 1; k++)
                        {
                            operations[k - 1] = operations[k];
                            numbers[k] = numbers[k + 1];
                        }
                        numbers[Num_of_num - 1] = 0;
                        Num_of_num--;
                        i--;
                    }
                }
                catch { }
            }


            while (Num_of_num != 1)
            {
                if (operations[id] == '+')
                {
                    Result = numbers[id] + numbers[id + 1];
                    numbers[id + 1] = Result;
                }
                else if (operations[id] == '-')
                {
                    Result = numbers[id] - numbers[id + 1];
                    numbers[id + 1] = Result;
                }
                numbers[id + 1] = Result;
                id++;
                Num_of_num--;
            }

            for (int i = 0; i < Result.ToString().Length - 1; i++)
            {
                if (Result.ToString()[i] == '.')
                {
                    dot = true;
                }
            }
            return Result.ToString();
        }

        public void Is_there_dot(string textbox)
        {
            dot = false;
            for (int i = 0; i < textbox.Length; i++)
            {
                if (textbox[i] == '.')
                {
                    dot = true;
                    break;
                }
            }
        }
    }
}
