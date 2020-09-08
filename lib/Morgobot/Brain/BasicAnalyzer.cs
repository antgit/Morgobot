using Dagon.Grammar;

namespace Morgobot.Brain
{
    public class BasicAnalyzer : IAnalyzer
    {
        public int Order => 2;

        public string Analyse(Phrase phrase, long chatId)
        {
            if (phrase.ToString() == "start")
            {
                return "Вечер в хату, часик в радость!";
            }

            if (phrase.HasWord("гусь"))
            {
                return "Сам ты гусь!";
            }

            if (phrase.HasAnyWord("пукнуть","пукни"))
            {
                return "\u2601";
            }

            if (phrase.HasWord("зигани"))
            {
                return "o/";
            }

            if (phrase.HasWord("спасибо"))
            {
                return "Пожалуйста";
            }

            if (phrase.HasWord("привет"))
            {
                return "Привет, козлик!";
            }

            if (phrase.HasAnyWord("300", "триста"))
            {
                return "Отсоси у тракториста!!! У ха ха ха ха!!!!";
            }

            if (phrase.HasAnyWord("верни", "вернем", "отдай") && phrase.HasAnyWord("коня", "лошадь"))
            {
                return "Не брал я твоего коня!!!";
            }

            if (phrase.HasWord("телефон"))
            {
                return "Я разбил свой телефон((( Хнык((";
            }

            if (phrase.HasAnyWord("пиво", "бухать", "водку") && !phrase.HasWord("не"))
            {
                if (phrase.HasAnyWord("пойдем", "пошли", "идем"))
                {
                    return "Пошли!";
                }
                if (phrase.HasWord("давай"))
                {
                    return "Давай!";
                }
            }

            if (phrase.IsEmpty())
            {
                return null;
            }

            if (phrase.LastWord.ToString() == "да")
            {
                return "Пизда!";
            }

            if (phrase.LastWord.ToString() == "нет")
            {
                return "Пидора ответ!";
            }

            if (phrase.HasWord("где"))
            {
                return "В пизде!";
            }

            return null;
        }
    }
}
