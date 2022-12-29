// Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы
// После записи элементов в массив, необходимо его вывести на экран.
Console.Clear();
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < n; i++){
    Console.Clear();
    Console.WriteLine($"Введите элемент массива {i + 1}/{n}");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();
Console.WriteLine($"[{string.Join(", ", arr)}]");