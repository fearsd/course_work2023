namespace course_work2023.Data;
class HistoryManager {
    private static string file = "history.txt";


    public static string ReadMessages() {
        string[] lines = File.ReadAllLines(file);
        string ans = "";
        foreach (string line in lines)
        {
            ans += $"{line} <br/><br/>";
        }
        return ans;
    }
    public static void WriteMessage(string a, string b, string c, string mess1, string mess2 = "", bool isA = false, bool isD = false) {
        string message = DateTime.Now.ToString();
        message += $" a = {a}, b = {b}, c = {c};<br/>";
        if (isA) {
            message += $"Выведена ошибка: {mess1}<br/>";
        }
        else if (isD) {
            message += $"Выведен ответ: {mess1}<br/>";
        }
        if (mess2 != "") {
            message += $"Уравнение: {mess2}";
        }
        
        File.AppendAllLines(file, new string[] {message});
    }
}