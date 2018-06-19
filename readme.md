DanNik.BrokenLine

Проект DanNik.BrokenLine содержит экспортируемый функционал заключенный в сервисе BrokenLineService

Проект DanNik.BrokenLine.Common содержит общую логику: 
	- Настройку DI модуля (CommonModule, ConsoleAppModule)
	- AmbientContext (общий контекст библиотеки, так же выполняет фунцию инициализации DI модуля)
	- HandlerProcessor(функционал для вызовы бизнес хендлеров с помощью DI)

Проект DanNik.BrokenLine.BusinessObjects содержит используемые объекты и контракты - что позволит переиспользовать 

Проект DanNik.BrokenLine.BusinessLogic содержит бизнесс логику - что позволит переиспользовать ее, а так же тестировать

Проект DanNik.BrokenLine.Tests тесты функционала библиотеки, благодаря DI может содержать кастомную реализацию провайдеров данных и т.п.
	Тесты можно запустить из Test Explorer или из командной строки из папки проекта командой: dotnet test 

Проект DanNik.BrokenLine.ConsoleApp пример использования библиотеки