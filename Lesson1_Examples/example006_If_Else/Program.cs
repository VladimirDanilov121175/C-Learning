// Программа, приветствующая одного из пользователей по особому
// Условия if-else

Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") 
// ToLower делает любые введенные заглавные буквы прописными. Делается это на случай, если
// пользователь наберет, например "мАша" или "МАша". Все буквы "выравниваются" и текст сравнивается
{
    Console.WriteLine("Ура, это же Маша!");
}    
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}