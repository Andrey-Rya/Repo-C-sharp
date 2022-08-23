// Метод-02 (void группа) Ничего не возвращают но могут принимать аргументы

void Method2(string msg) // (Method2-идентифик) string msg - кол-во аргументов
{
    Console.WriteLine(msg);//выводим сообщение с аргументами msg
}
// Method2("Текст сообщения метода 2"); // так вызывается данный вид метода

/*--------------------------------*/
//- здесь можно присваивать разное значение для разых аргументов

void Method21(string msg) // (Method2-идентифик) string msg - кол-во аргументов
{
    Console.WriteLine(msg);//выводим сообщение с аргументами msg
}
Method21(msg: "Текст сообщения 21 метод");

void Method22(string msg, int count) // string msg - кол-во аргументов
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method22("Текст сообщения для 22 метода", 4);// вызываем текст 4 раза

/*--------------------------------*/
//- можно так же указать какому аргументу какое значение мы присвоим

void Method23(string msg, int count) // (Method2-идентифик) string msg - кол-во аргументов
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method23(msg:"Текст для 23 метода", count: 4);// повторить 4 раза текст для msg
Method23(count: 4, msg: "новый Текст для 23 метода"); // можно менять их местами