using OOP3;

//Managers
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

//Logs
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService>(){databaseLoggerService,fileLoggerService,new SmsLoggerService()};

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, loggers);

List<IKrediManager> krediler = new List<IKrediManager>(){new EsnafKredisiManager(),konutKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

//interfaceyi birbirinin alternatifi olan ama kod içerikleri farklı olan şeyleri için kullanırız.