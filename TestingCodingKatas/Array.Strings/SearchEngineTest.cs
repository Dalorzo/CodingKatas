using System.Collections.Generic;
using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class SearchEngineTest
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void TestBasicSimilarWords()
        {
            var se = new SearchingEngine();
            var products = new string[] {"tarro","carro","jarro"};
            var result = se.SuggestedProducts(products,"jamon");
            var output = new List<IList<string>>();
            output.Add(new List<string>( new string[]{"jarro"}));
            output.Add(new List<string>( new string[]{"jarro"}));
            output.Add(new List<string>( new string[]{}));
            output.Add(new List<string>( new string[]{}));
            output.Add(new List<string>( new string[]{}));
            Assert.AreEqual(output, result, "[tarro, carro, jarro], searchWord = jamon");
        }
        
        [Test]
        public void TestBasicOneLetterWords()
        {
            var se = new SearchingEngine();
            var products = new string[] {"tarro","carro","jarro","j"};
            var result = se.SuggestedProducts(products,"jamon");
            var output = new List<IList<string>>();
            output.Add(new List<string>( new string[]{"j","jarro"}));
            output.Add(new List<string>( new string[]{"jarro"}));
            output.Add(new List<string>( new string[]{}));
            output.Add(new List<string>( new string[]{}));
            output.Add(new List<string>( new string[]{}));
            Assert.AreEqual(output, result, "[tarro, carro, jarro], searchWord = jamon");
        }


        [Test]
        public void TestBasicLoading()
        {
            var se = new SearchingEngine();
            var products = new string[] {"mobile","mouse","moneypot","monitor","mousepad"};
            var result = se.SuggestedProducts(products,"mouse");
            var output = new List<IList<string>>();
            output.Add(new List<string>( new string[]{"mobile","moneypot","monitor"}));
            output.Add(new List<string>( new string[]{"mobile","moneypot","monitor"}));
            output.Add(new List<string>( new string[]{"mouse","mousepad"}));
            output.Add(new List<string>( new string[]{"mouse","mousepad"}));
            output.Add(new List<string>( new string[]{"mouse","mousepad"}));
            Assert.AreEqual(output, result, "[mobile,mouse,moneypot,monitor,mousepad], searchWord = mouse");
        }
        [Test]
        public void TestOnlyOneProduct()
        {
            var se = new SearchingEngine();
            var products = new string[] {"havana"};
            var result = se.SuggestedProducts(products,"havana");
            var output = new List<IList<string>>();
            output.Add(new List<string>( new string[]{"havana"}));
            output.Add(new List<string>( new string[]{"havana"}));
            output.Add(new List<string>( new string[]{"havana"}));
            output.Add(new List<string>( new string[]{"havana"}));
            output.Add(new List<string>( new string[]{"havana"}));
            output.Add(new List<string>( new string[]{"havana"}));
            Assert.AreEqual(output, result, "[havana], searchWord = havana");
        }
        
        [Test]
        public void TestMultipleLetterProduct()
        {
            var se = new SearchingEngine();
            var products = new string[] {"bags","baggage","banner","box","cloths"};
            var result = se.SuggestedProducts(products,"bags");
            var output = new List<IList<string>>();
            output.Add(new List<string>( new string[]{"baggage","bags","banner"}));
            output.Add(new List<string>( new string[]{"baggage","bags","banner"}));
            output.Add(new List<string>( new string[]{"baggage","bags"}));
            output.Add(new List<string>( new string[]{"bags"}));
            Assert.AreEqual(output, result, "[bags,baggage,banner,box,cloths], searchWord = bags");
        }
        
        [Test]
        public void TestNoMatch()
        {
            var se = new SearchingEngine();
            var products = new string[] {"mobile","mouse","moneypot","monitor","mousepad"};
            var result = se.SuggestedProducts(products,"maxi");
            var output = new List<IList<string>>();
            output.Add(new List<string>( new string[]{"mobile","moneypot","monitor"}));
            output.Add(new List<string>( new string[]{}));
            output.Add(new List<string>( new string[]{}));
            output.Add(new List<string>( new string[]{}));
            Assert.AreEqual(output, result, "[mobile,mouse,moneypot,monitor,mousepad], searchWord = maxi");
        }
        
        
        [Test]
        public void TestLongMatch()
        {
            var se = new SearchingEngine();
            var products = new string[] {"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnunqerptgas","zmmirsxdhyxvmdybjzondyvrkzeafhvualsivfueweuusmsxbttdeofzeripaqv","tyqcpfvorznmxxdzepfxabibcagilwjsqncxnpjqsxjzqqqbae","tyqcpfvacyrjvmadrmntxotgvgivdvcuwygpjfwcuppunolukrum","tyqcpfvrqwrcpusmfyhxaiasfbb","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqyalwiaj","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchidnpt","lfjkcljnd","zibrwfpwecubjlsjbkrhnvolnnzrqhdynloplzagwnuhpxhbvpxnqaifnln","ybswoottdgryxtupichpvqjmcoytrwnfgzrrnaejojvpzmttlzw","tyqcplghosxjviooiyddhvzzrhuuwkiosmgafxyajcdyqlmthqkoylxhtxdruw","okoscfpxcndzgbtsozdofgnomtglmoaewgzzjvrxezoq","cxkwvaytkxgafeltbanhsvxlorigkuxnsxlmhvwqm","iamtabcpdagicnvdvqcfykonsazrbdivxtczpgqgxjrifukmqjw","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbneryahanhrhkal","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnunl","tyqcpfvorznmxxdzsuyushueegfrnlzbydnefcfagqnxglkulegntoml","zlovtmburfkd","vlzfaamutsfqefpafzffwhvpfw","bbufxzwpryyakbxuhwwplvdptgybbykqxirsrahsokviihxrawcbgwrktvgacmwtc","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbzw","kjundphljswl","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqhlqnapfkcqpdb","stcphvgxvcaysehvrfdfllwvxf","epbtkgnnupbbdqgheyaks","gilhnlfkdz","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwghy","yswdsvnzucvsdzrmeghevjrfuhoebfedvyvortaxppwqncmspctdcjlwdxfnc","baizdtmgozykukcrkapsnp","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgcsfjgtwqqubbhjkzmio","iblyydfzztmtyjmgrxvyjwcobfyxcgyrbtnfhhxswxahze","tyqcpfyggtmjahhpjzwhohvchyofsxwkehq","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniaymgkdduoabmp","gpsqlqorcbqffdxlnijgvzvxilnbkynwscuoymqyg","eidradnaqjwmucbrgtp","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzopnqxxcxshbhdmippldmcuxlvc","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbfmryrbgicgzqecje","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuze","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs","tyqcqqxonxtwakxlrceyknbockvovdwumbjkfrgmudiafbqlflonfavpsrfq","tyqcpfvorznmxxdzsnkjnrrzpfourbghe","ziarqmfvzqpqhunfxwfwjtetotozkjaszznbtrvtxarysaxq","tyqcpfvorznmxfmlzlcuikpxvahtfbfipjcgmeusshufvnirwcopdnvnop","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvdertpdpdjsngezrnyjxotgonuigmqkgipgb","tyqcpfvorznmxxdzsnkjnrrzpfvfcvufmzzuqrjubsfzp","tyqcpfvorznmxxdzsnkjnrrzpfgknvqorqffebhoyfvgkspenqpcmvoxpybkjg","oqojrvinnhlwuqllcsabkpfiusfucpjbsxzzhlgduawaqyp","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqnzudhzclswotlbgdffwiekw","csgadyglxddodloklsegvsbtgtkloklmxkbxxyorcqwybktuzpyeaqasn","tyqitegmijccjwxuwvchbvuvllmgsdugzxdkiqvnllhmsjyskxpzzds","tyqcpfvorznigwmavbguxwhunsshdybhzszxvlnpingqgaghkqzeynbbbhgcxeydir","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnunflh","tyqcpfvorznmbwmhfmudnurhismirfgvojpdmclw","tyqcpfvjijiwoup","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb","tyqcpfvorznmxxdzsnkjhvabtzucyooctzzrgehlsuyinrrnzjilfpalvqgwoey","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie","tyqcpfvorznmxxxvjwfgcwegpibuifhfxyomnicutaegshpnschktxknqytritr","tyqcpfvorznetvhiaobezckojwjbeg","tyqcpfvorzmjabuccipqln","frutebajqddrtrsmabfmdcgipssymldwscxbbrbpb","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviotvqi","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchxeyrnlh","yaxaddctugikoutgcwqsdekghoemtooljxvysnzqqvgpc","tyqcpfvorznmxxdzsnkjn","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqggjwxdvqesbgrqei","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckoktdj","mzwjshgbgbdogqbrhfgbjkrqogyynbdwwkdclsbpynlrhxeucuuo","tyqcpfvorznmxxdzsnkjnrrztrqgpbvvxm","u","tyqcpfvorznmxjnsgyirdtzpwywpnrvgadkmdjghlmerbqysaebyge","tyqcpfvorznmxxdzsnkjnrkjelwoqorxsnyjqdnxfava","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvqqy","hcav","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviof","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwreznx","yesupowwycvcdbknhrkfyvnpoqtdhcbhybqvhnvgukoohh","hcvlnbmcrepblcqrvwpfsyevlpyldptubnxkntqhpounxjcw","lwaxzivycjkanvikqpbrvdvjkaclyuyfitwfycsnfwjg","tkruiswrcbzsbkwbhhvjzzuuiayqzbxjosjssacislcvbtcojpmyatkfgyx","ftujoohzvjonlwxwskeydoxpfvbvrdndbhgpuvykif","tyqcpfvorznmxxdzsnkjnrrzpfgknvqqngbpbdtufkgunalbekxbkpajlgbjtqmswh","tyqcpfvorznmxxdzsnkjnrrzpewgvvnicz","tyqcpfvorznmxxdzsnkjnrrzpfgknjxnepksgdzwxsbziwdzsiiyarxhtpp","jumcvboxaxjfybdlezcjrarolxjtsuweaigkiudusinfmnczdualqzlpwkm","tyqcpfvoxegnpqesbaugr","bteznmwyh","rtbpifxevchngjnlumvtqtpebgtoznvvrzfxqzmcktoxydbstbvukrunnyeqwfd","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejysfrlewzsgukyahggau","mvrrbfbfwyrxooopgcbwmtjfepejyfrqdkyaqencqqlagoilrtdndfyn","tyqcpfvorznmyrzwhjxvhooytltygrakvgkqumrimazzhzoueyqnjz","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviob","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwoyvqczogovza","tyqcpfvorznmxxdzsnkjnrrzpfgknvfnzshqqfpr","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjghvqg","zqrnaierpnsigujuxrftdiauazddadqmrwcimxyztwumwzyjcrqvuexnitdecfgo","xusxbbilivpovzsjvfsdnacipk","tyqcpfvorznmxxdzkbqgrgeolnwhtvlckmiattpmxwwtmlifnexxbgtpjslwhczrjlhr","eiuytvdzhcodcrdgthxynurtpsdyguupijjluucpfinrfnsjkdbbzexfmctejlgvd","tyqcpfudqjrabwwvdvwmsyscnazaxpsjjhetouegipqevvointclztzummwrrbntjlsj","tyqcpfvobzfvbiuoktjcqjfx","tyqcpfvorznmxxdzsnamc","ajqpomnpmsayhelmhfehjbvjaeszqigfqyuixbtyjy","jpfxangixfavlhcssecxljksydrjxmaldhwpftinywtbmffsmtslefcuddk","txryxhtutwdrqmpcapbcrlmhzsobueefwfekusmmylr","etzqiepphjcleaocnwljcdn","tyqcpfvokfxlbmbzmitacnromkoaoxl","iddmxxcmwecfutbrbqeihhlnypckofuhkbydmljfemzrvlxsuskxkbgviybzu","tyqcpfvorznmxxdzwilcfwrdlfqppdnuvgltuoooppwyomtvtggmsfxsxievdlsyame","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvzquhbkvburnhmerkuabrfcjwanzmfenz","tyqcpqgaus","zsbcqgctsjdjyfkdvcehawsqzacafwtjmhemfygdahkexvmkqkcehvek","tyqcpfvorznmxxdzsnkjfesxjshxtlinfjltdfl","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnubpoqoghhgbpew","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdcuudsuqq","tyqcpgwivyfquxqhbkjbioekqbsd","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnudxocavmwpggka","tyqcpfvorznmxxdzsnkjnrrzpfgknvnlxdokehsjhiohwdeyikeajzipztzhwmxc","pmpoycdxttisazazsgiswnsnhdmejpjbygvtjhwqydeugbouekvornbeiwmpehikbz","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwcpoxr","qmgnrjtavzsqtwareroiihendgcvbzbcolvfoanmixxrxdtnmtevvv","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnunix","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetxpdyhmk","tyqcpfvorznmxxdzsnkjnrfmy","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy","tyqcpfzmlffhifutomuvfvwaqatopvur","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvdvagddprewvlgx","ozmyertmnlwybntwxmpynuynhqdbqhosvjwexzqgvdtnvxexxwwwwhqktmzbfkjfn","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof","rniiqnzbctzeyeeyrxhfzqgbccplsncvtswcrqmevplfzadlulazmpmhdojwaokn","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx","tyqcpfvorznmxxdzsnkjnrrzpfgkhdwienfhpsqbyrvotbgchkkmvk","tyqcpfvorznmxxdzsnkjnrrumaqtylptffsjzygeumkahutdmalkqtrhtgrsrqcyyti","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvioncnr","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvigzpo","tyqcpfvorznmxxdzsnkjnrrzpfgkeduq","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnccdnakfkhtg","lhehmbyzcnlwvr","tyqcpfvojuuprlby","wds","tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqvegfwmtdcrvdb","tyqcpfvorznpkeynkmbbyptclmhxxlyjzejqbcatgfrmkbbmxs","tyqcpfvorznmiqmfrhihxsagizcrwyaukrjwbbgrxdzknq","ghhlssixrouzbqcpmxzmsnybaygtb","jndewk","tyqcpfvorznmxxdzsnkjnrrzpdqanmxattjhgnflnoyynevsxvpbwfmfrnlc"};
            var result = se.SuggestedProducts(products,"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviotvdticwxwcliylrpvrokbcguhnfvpd");
            var output = new List<IList<string>>(new string[][]
            {new string[]{"tkruiswrcbzsbkwbhhvjzzuuiayqzbxjosjssacislcvbtcojpmyatkfgyx",
                "txryxhtutwdrqmpcapbcrlmhzsobueefwfekusmmylr",
                "tyqcpfudqjrabwwvdvwmsyscnazaxpsjjhetouegipqevvointclztzummwrrbntjlsj"},
                new string[] { "tyqcpfudqjrabwwvdvwmsyscnazaxpsjjhetouegipqevvointclztzummwrrbntjlsj",
                "tyqcpfvacyrjvmadrmntxotgvgivdvcuwygpjfwcuppunolukrum",
                "tyqcpfvjijiwoup"},
                new string[] {"tyqcpfudqjrabwwvdvwmsyscnazaxpsjjhetouegipqevvointclztzummwrrbntjlsj",
                "tyqcpfvacyrjvmadrmntxotgvgivdvcuwygpjfwcuppunolukrum",
                "tyqcpfvjijiwoup"},
                new string[]{"tyqcpfudqjrabwwvdvwmsyscnazaxpsjjhetouegipqevvointclztzummwrrbntjlsj",
                "tyqcpfvacyrjvmadrmntxotgvgivdvcuwygpjfwcuppunolukrum",
                "tyqcpfvjijiwoup"},
                new string[]{"tyqcpfudqjrabwwvdvwmsyscnazaxpsjjhetouegipqevvointclztzummwrrbntjlsj",
                "tyqcpfvacyrjvmadrmntxotgvgivdvcuwygpjfwcuppunolukrum",
                "tyqcpfvjijiwoup"},
                new string[]{"tyqcpfudqjrabwwvdvwmsyscnazaxpsjjhetouegipqevvointclztzummwrrbntjlsj",
                "tyqcpfvacyrjvmadrmntxotgvgivdvcuwygpjfwcuppunolukrum",
                "tyqcpfvjijiwoup"},
                new string[]{"tyqcpfvacyrjvmadrmntxotgvgivdvcuwygpjfwcuppunolukrum", "tyqcpfvjijiwoup",
                "tyqcpfvobzfvbiuoktjcqjfx"},
                new string[]{"tyqcpfvobzfvbiuoktjcqjfx", "tyqcpfvojuuprlby",
                "tyqcpfvokfxlbmbzmitacnromkoaoxl"},
                new string[]{"tyqcpfvorzmjabuccipqln", "tyqcpfvorznetvhiaobezckojwjbeg",
                "tyqcpfvorznigwmavbguxwhunsshdybhzszxvlnpingqgaghkqzeynbbbhgcxeydir"},
                new string[]{"tyqcpfvorzmjabuccipqln",
                "tyqcpfvorznetvhiaobezckojwjbeg",
                "tyqcpfvorznigwmavbguxwhunsshdybhzszxvlnpingqgaghkqzeynbbbhgcxeydir"},new string[]{"tyqcpfvorznetvhiaobezckojwjbeg",
                "tyqcpfvorznigwmavbguxwhunsshdybhzszxvlnpingqgaghkqzeynbbbhgcxeydir",
                "tyqcpfvorznmbwmhfmudnurhismirfgvojpdmclw"},new string[]{"tyqcpfvorznmbwmhfmudnurhismirfgvojpdmclw",
                "tyqcpfvorznmiqmfrhihxsagizcrwyaukrjwbbgrxdzknq",
                "tyqcpfvorznmxfmlzlcuikpxvahtfbfipjcgmeusshufvnirwcopdnvnop"},new string[]{
                "tyqcpfvorznmxfmlzlcuikpxvahtfbfipjcgmeusshufvnirwcopdnvnop",
                "tyqcpfvorznmxjnsgyirdtzpwywpnrvgadkmdjghlmerbqysaebyge",
                "tyqcpfvorznmxxdzepfxabibcagilwjsqncxnpjqsxjzqqqbae"},new string[]{
                "tyqcpfvorznmxxdzepfxabibcagilwjsqncxnpjqsxjzqqqbae",
                "tyqcpfvorznmxxdzkbqgrgeolnwhtvlckmiattpmxwwtmlifnexxbgtpjslwhczrjlhr",
                "tyqcpfvorznmxxdzsnamc"},new string[]{"tyqcpfvorznmxxdzepfxabibcagilwjsqncxnpjqsxjzqqqbae",
                "tyqcpfvorznmxxdzkbqgrgeolnwhtvlckmiattpmxwwtmlifnexxbgtpjslwhczrjlhr",
                "tyqcpfvorznmxxdzsnamc"},new string[]{"tyqcpfvorznmxxdzepfxabibcagilwjsqncxnpjqsxjzqqqbae",
                "tyqcpfvorznmxxdzkbqgrgeolnwhtvlckmiattpmxwwtmlifnexxbgtpjslwhczrjlhr",
                "tyqcpfvorznmxxdzsnamc"},new string[]{"tyqcpfvorznmxxdzsnamc", "tyqcpfvorznmxxdzsnkjfesxjshxtlinfjltdfl",
                "tyqcpfvorznmxxdzsnkjhvabtzucyooctzzrgehlsuyinrrnzjilfpalvqgwoey"},new string[]{"tyqcpfvorznmxxdzsnamc",
                "tyqcpfvorznmxxdzsnkjfesxjshxtlinfjltdfl",
                "tyqcpfvorznmxxdzsnkjhvabtzucyooctzzrgehlsuyinrrnzjilfpalvqgwoey"},new string[]{
                "tyqcpfvorznmxxdzsnkjfesxjshxtlinfjltdfl",
                "tyqcpfvorznmxxdzsnkjhvabtzucyooctzzrgehlsuyinrrnzjilfpalvqgwoey",
                "tyqcpfvorznmxxdzsnkjn"},new string[]{"tyqcpfvorznmxxdzsnkjfesxjshxtlinfjltdfl",
                "tyqcpfvorznmxxdzsnkjhvabtzucyooctzzrgehlsuyinrrnzjilfpalvqgwoey",
                "tyqcpfvorznmxxdzsnkjn"},new string[]{"tyqcpfvorznmxxdzsnkjn", "tyqcpfvorznmxxdzsnkjnrfmy",
                "tyqcpfvorznmxxdzsnkjnrkjelwoqorxsnyjqdnxfava"},new string[]{"tyqcpfvorznmxxdzsnkjnrfmy",
                "tyqcpfvorznmxxdzsnkjnrkjelwoqorxsnyjqdnxfava",
                "tyqcpfvorznmxxdzsnkjnrrumaqtylptffsjzygeumkahutdmalkqtrhtgrsrqcyyti"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrumaqtylptffsjzygeumkahutdmalkqtrhtgrsrqcyyti",
                "tyqcpfvorznmxxdzsnkjnrrzpdqanmxattjhgnflnoyynevsxvpbwfmfrnlc",
                "tyqcpfvorznmxxdzsnkjnrrzpewgvvnicz"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpdqanmxattjhgnflnoyynevsxvpbwfmfrnlc",
                "tyqcpfvorznmxxdzsnkjnrrzpewgvvnicz",
                "tyqcpfvorznmxxdzsnkjnrrzpfgkeduq"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpdqanmxattjhgnflnoyynevsxvpbwfmfrnlc",
                "tyqcpfvorznmxxdzsnkjnrrzpewgvvnicz",
                "tyqcpfvorznmxxdzsnkjnrrzpfgkeduq"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgkeduq",
                "tyqcpfvorznmxxdzsnkjnrrzpfgkhdwienfhpsqbyrvotbgchkkmvk",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknjxnepksgdzwxsbziwdzsiiyarxhtpp"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgkeduq",
                "tyqcpfvorznmxxdzsnkjnrrzpfgkhdwienfhpsqbyrvotbgchkkmvk",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknjxnepksgdzwxsbziwdzsiiyarxhtpp"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgkeduq",
                "tyqcpfvorznmxxdzsnkjnrrzpfgkhdwienfhpsqbyrvotbgchkkmvk",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknjxnepksgdzwxsbziwdzsiiyarxhtpp"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknjxnepksgdzwxsbziwdzsiiyarxhtpp",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvfnzshqqfpr",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvnlxdokehsjhiohwdeyikeajzipztzhwmxc"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvfnzshqqfpr",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvnlxdokehsjhiohwdeyikeajzipztzhwmxc",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqorqffebhoyfvgkspenqpcmvoxpybkjg"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqorqffebhoyfvgkspenqpcmvoxpybkjg",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqqngbpbdtufkgunalbekxbkpajlgbjtqmswh",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckoktdj",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckoktdj",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckoktdj",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckoktdj",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckoktdj",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx"},new string[]{"tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckohyof",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckoktdj",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzakckmtmjxx",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqandxbuvshebs",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbfmryrbgicgzqecje"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbfmryrbgicgzqecje"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejemb",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbfmryrbgicgzqecje"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetaoqgbczdcemzlmqemy",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbfmryrbgicgzqecje",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnccdnakfkhtg"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbfmryrbgicgzqecje",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnccdnakfkhtg",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbneryahanhrhkal"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnccdnakfkhtg",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbneryahanhrhkal",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnubpoqoghhgbpew"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnubpoqoghhgbpew",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnudxocavmwpggka",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnunflh"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnunflh",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniaymgkdduoabmp",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwcpoxr"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniaymgkdduoabmp",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwcpoxr",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwghy"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwcpoxr",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwghy",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwreznx"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchidnpt",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchidnpt",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchidnpt",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchidnpt",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchidnpt",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchidnpt",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvigzpo"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviaxsw",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvie",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvigzpo"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviob",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviof",
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchvioncnr"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviotvqi"},new string[]{
                "tyqcpfvorznmxxdzsnkjnrrzpfgknvqvderckuzdqqgaqejetbnuniwwjbdchviotvqi"},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{
                },new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{},new string[]{}, new string[]{ }
            });
   
   
            Assert.AreEqual(output, result, "[long words], searchWord = maxi");
        }

    }
}