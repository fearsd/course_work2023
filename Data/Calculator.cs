namespace course_work2023.Data;
class Calculator {

    public double A {get;set;}
    public double B {get;set;}
    public double C {get;set;}
    public Calculator(string a, string b = "", string c = "") {
        A = normalizeNumber(a);
        B = normalizeNumber(b);
        C = normalizeNumber(c);
    }

    public string calcAnswer() {
        double D = Math.Pow(B, 2) - 4 * A * C;
        if (D < 0) return "Дискриминант получился отрицательным, невозможно вычислить корни";
        else if (D == 0) {
            double x = - B / (2 * A);
            return $"Корень x = {x}";
        }
        else {
            double x1 = (- B + Math.Sqrt(D)) / (2 * A);
            double x2 = (- B - Math.Sqrt(D)) / (2 * A);
            return $"Корень x<sub>1</sub> = {x1} <br/>Корень x<sub>2</sub> = {x2}";
        }

    }
    private double normalizeNumber(string num) {
        if (num == "") return 0;
        return double.Parse(num);
    }
}