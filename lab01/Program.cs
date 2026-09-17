Console.WriteLine($"компьютер: {Environment.MachineName}");

Console.WriteLine($"пользователь: {Environment.UserName}");

Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");


Console.WriteLine($"OC: {Environment.OSVersion}");
Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");

Console.WriteLine($"логических процесов: {Environment.ProcessorCount}");

Console.WriteLine($"PID процесса : {Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {memory} МБ");
Console.WriteLine();
