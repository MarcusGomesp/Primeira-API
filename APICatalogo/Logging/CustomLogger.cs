namespace APICatalogo.Logging
{
    public class CustomLogger : ILogger
    {
        public string loggerName { get; }
        public CustomLoggerProviderConfiguration loggerConfig { get; }
        public CustomLogger(string name, CustomLoggerProviderConfiguration logerConfig)
        {
            loggerName = name;
            loggerConfig = logerConfig;
        }
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel == loggerConfig.Level;
        }

        public void Log<TState>(LogLevel loglevel, EventId eventId, TState state,
                        Exception exception, Func<TState, Exception, string> formatter)
        {
            string message = $"{loglevel.ToString()}: {eventId.Id} -{formatter(state, exception)}";
            EscreverTextoArquivo(message);
        }

        private void EscreverTextoArquivo(string mensagem)
        {
            string caminhoArquivo = @"C:\Users\user\Desktop\RegistroMSG\Teste.txt";

            using (StreamWriter streamWriter = new StreamWriter(caminhoArquivo, true))
            {
                try
                {
                    streamWriter.WriteLine(mensagem);
                    streamWriter.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


    }
}
