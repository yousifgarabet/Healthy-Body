using System.Collections.Generic;

namespace Healthy_Body.Portable.TipsPage
{
    public class GetTipses
    {
        public IList<Tips> Tipses { get; private set; }

        public IList<Tips> GetLoseTipses()
        {
            Tipses = new List<Tips>
            {
                new Tips { TipsID = "1", TipsHeader = "Do not skip breakfast", TipsDetail = "Skipping breakfast will not help you lose weight. You could miss out on essential nutrients and you may end up snacking more throughout the day because you feel hungry." },
                new Tips { TipsID = "2", TipsHeader = "Eat regular meals", TipsDetail = "Eating at regular times during the day helps burn calories at a faster rate. It also reduces the temptation to snack on foods high in fat and sugar." },
                new Tips { TipsID = "3", TipsHeader = "Eat plenty of fruit and veg", TipsDetail = "Fruit and veg are low in calories and fat, and high in fibre – 3 essential ingredients for successful weight loss. They also contain plenty of vitamins and minerals." },
                new Tips { TipsID = "4", TipsHeader = "Get more active", TipsDetail = "Being active is key to losing weight and keeping it off. As well as providing lots of health benefits, exercise can help burn off the excess calories you cannot lose through diet alone." },
                new Tips { TipsID = "5", TipsHeader = "Drink plenty of water", TipsDetail = "People sometimes confuse thirst with hunger. You can end up consuming extra calories when a glass of water is really what you need." },
                new Tips { TipsID = "6", TipsHeader = "Eat high fibre foods", TipsDetail = "Foods containing lots of fibre can help keep you feeling full, which is perfect for losing weight. Fibre is only found in food from plants, such as fruit and veg, oats, wholegrain bread, brown rice and pasta, and beans, peas and lentils." },
                new Tips { TipsID = "7", TipsHeader = "Read food labels", TipsDetail = "Knowing how to read food labels can help you choose healthier options. Use the calorie information to work out how a particular food fits into your daily calorie allowance on the weight loss plan." },
                new Tips { TipsID = "8", TipsHeader = "Use a smaller plate", TipsDetail = "Using smaller plates can help you eat smaller portions. By using smaller plates and bowls, you may be able to gradually get used to eating smaller portions without going hungry. It takes about 20 minutes for the stomach to tell the brain it's full, so eat slowly and stop eating before you feel full." },
                new Tips { TipsID = "9", TipsHeader = "Do not ban foods", TipsDetail = "Do not ban any foods from your weight loss plan, especially the ones you like. Banning foods will only make you crave them more. There's no reason you cannot enjoy the occasional treat as long as you stay within your daily calorie allowance." },
                new Tips { TipsID = "10", TipsHeader = "Do not stock junk food", TipsDetail = "To avoid temptation, do not stock junk food – such as chocolate, biscuits, crisps and sweet fizzy drinks – at home. Instead, opt for healthy snacks, such as fruit, unsalted rice cakes, oat cakes, unsalted or unsweetened popcorn, and fruit juice." },
                new Tips { TipsID = "11", TipsHeader = "Cut down on alcohol", TipsDetail = "A standard glass of wine can contain as many calories as a piece of chocolate. Over time, drinking too much can easily contribute to weight gain." },
                new Tips { TipsID = "12", TipsHeader = "1Plan your meals", TipsDetail = "Try to plan your breakfast, lunch, dinner and snacks for the week, making sure you stick to your calorie allowance. You may find it helpful to make a weekly shopping list." }
            };
            return Tipses;
        }

        public IList<Tips> GetKeepTipses()
        {
            Tipses = new List<Tips>
            {
                new Tips { TipsID = "1", TipsHeader = "Maintain a Healthy Weight", TipsDetail = "Keeping your weight in check is often easier said than done, but a few simple tips can help. First off, if you’re overweight, focus initially on not gaining any more weight. This by itself can improve your health. Then, when you’re ready, try to take off some extra pounds for an even greater health boost." },
                new Tips { TipsID = "2", TipsHeader = "Exercise Regularly", TipsDetail = "Few things are as good for you as regular physical activity. While it can be hard to find the time, it’s important to fit in at least 30 minutes of activity every day. More is even better, but any amount is better than none." },
                new Tips { TipsID = "3", TipsHeader = "Don’t Smoke", TipsDetail = "You’ve heard it before: If you smoke, quitting is absolutely the best thing you can do for your health. Yes, it’s hard, but it’s also far from impossible. More than 1,000 Americans stop for good every day." },
                new Tips { TipsID = "4", TipsHeader = "Eat a Healthy Diet", TipsDetail = "Despite confusing news reports, the basics of healthy eating are actually quite straightforward. You should focus on fruits, vegetables and whole grains and keep red meat to a minimum. It’s also important to cut back on bad fats (saturated and trans fats) and choose healthy fats (polyunsaturated and monounsaturated fats) more often. Taking a multivitamin with folate every day is a great nutrition insurance policy." },
                new Tips { TipsID = "5", TipsHeader = "Drink Alcohol Only in Moderation, If at All", TipsDetail = "Moderate drinking is good for the heart, as many people already know, but it can also increase the risk of cancer. If you don’t drink, don’t feel that you need to start. If you already drink moderately (less than one drink a day for women, less than two drinks a day for men), there’s probably no reason to stop. People who drink more, though, should cut back." },
                new Tips { TipsID = "6", TipsHeader = "Protect Yourself from the Sun", TipsDetail = "While the warm sun is certainly inviting, too much exposure to it can lead to skin cancer, including serious melanoma. Skin damage starts early in childhood, so it’s especially important to protect children." },
                new Tips { TipsID = "7", TipsHeader = "Protect Yourself From Sexually Transmitted Infections", TipsDetail = "Among other problems, sexually transmitted infections – like human papillomavirus (HPV) – are linked to a number of different cancers. Protecting yourself from these infections can lower your risk." },
                new Tips { TipsID = "8", TipsHeader = "Get Screening Tests", TipsDetail = "There are a number of important screening tests that can help protect against cancer. Some of these tests find cancer early when they are most treatable, while others can actually help keep cancer from developing in the first place. For colorectal cancer alone, regular screening could save over 30,000 lives each year. That’s three times the number of people killed by drunk drivers in the United States in all of 20Talk to a health care professional about which tests you should have and when." },
                new Tips { TipsID = "9", TipsHeader = "Cancers that should be tested for regularly", TipsDetail = "Colon and rectal cancer, Breast cancer, Cervical cancer, and Lung cancer(in current or past heavy smokers)" }
            };
            return Tipses;
        }

        public IList<Tips> GetGainTipses()
        {
            Tipses = new List<Tips>
            {
                new Tips { TipsID = "1", TipsHeader = "Don't drink water before meals.", TipsDetail = "This can fill your stomach and make it harder to get in enough calories." },
                new Tips { TipsID = "2", TipsHeader = "Eat more often", TipsDetail = "Squeeze in an additional meal or snack whenever you can, such as before bed." },
                new Tips { TipsID = "3", TipsHeader = "Drink milk", TipsDetail = "Drinking whole milk to quench thirst is a simple way to get in more high-quality protein and calories." },
                new Tips { TipsID = "4", TipsHeader = "Try weight gainer shakes", TipsDetail = "If you’re really struggling then you can try weight gainer shakes. These are very high in protein, carbs and calories." },
                new Tips { TipsID = "5", TipsHeader = "Use bigger plates", TipsDetail = "Definitely use large plates if you’re trying to get in more calories, as smaller plates cause people to automatically eat less." },
                new Tips { TipsID = "6", TipsHeader = "Add cream to your coffee", TipsDetail = "This is a simple way to add in more calories." },
                new Tips { TipsID = "7", TipsHeader = "Take creatine", TipsDetail = "The muscle building supplement creatine monohydrate can help you gain a few pounds in muscle weight." },
                new Tips { TipsID = "8", TipsHeader = "Get quality sleep", TipsDetail = " Sleeping properly is very important for muscle growth." },
                new Tips { TipsID = "9", TipsHeader = "Eat your protein first and vegetables last", TipsDetail = "If you have a mix of foods on your plate, eat the calorie-dense and protein-rich foods first. Eat the vegetables last." },
                new Tips { TipsID = "10", TipsHeader = "Don't smoke.", TipsDetail = "Smokers tend to weigh less than non-smokers, and quitting smoking often leads to weight gain." }
            };
            return Tipses;
        }
    }
}
