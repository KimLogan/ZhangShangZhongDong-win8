using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace App1
{

  public class food_
  {
    public string name_ { get; set; }
    public string text_ { get; set; }
    public string taste_ { get; set; }
    public string species_ { get; set; }
    public double price_min { get; set; }
    public double price_max { get; set; }
    public string price_ { get; set; }
    public double score_ { get; set; }

  }


  /// <summary>
  /// 可用于自身或导航至 Frame 内部的空白页。
  /// </summary>
  public sealed partial class food : Page
  {
    List<food_> listitems1 = new List<food_>()
      {
        new food_() {
          name_ = "套餐窗口",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "5-6元",
          price_max = 6,
          price_min = 5,
          score_ = 3.5,
          text_ = "一饭的套餐有6元、5元两种，是一饭最实惠的正餐。对于那些想要省钱又想吃得饱的人来说，是一个好的选择。不过缺点呢，就是相对于二饭的套餐，菜的质量相对会差一点。",
        },
        new food_() {
          name_ = "自选窗口",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "5-12元",
          price_max = 12,
          price_min = 5,
          score_ = 4.5,
          text_ = "一饭的自选窗口一直是喜欢吃自选食物的人的最爱。在这里的主食你可以选择米饭或者是炒面、炒饭，菜品方面在四个食堂的自选里是最丰富也最好吃的，小菜的价位可以从5元到0.5元几个档位。同时这里的窗口还提供几种不错的煲汤，搭配正餐绝对是超赞的（推荐虫草瘦肉汤）。",
        },
        new food_() {
          name_ = "学一西餐",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "7-9元",
          price_max = 9,
          price_min = 7,
          score_ = 4,
          text_ = "一饭的西餐出现的时间比较晚。相对于二饭的西餐而言，这里的西餐可选的种类更加地丰富，分量也更加地足。如果非要说缺点的话，有个别鸡扒的质量可能存在一点问题，还有就是不送饮料，一大盘饭吃下去可能会觉得口干。不过还是蛮实惠的，尤其是喜欢吃肉的小伙伴绝对不可错过。",
        },
        new food_() {
          name_ = "鸡扒饭",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "7-9元",
          price_max = 9,
          price_min = 7,
          score_ = 3.5,
          text_ = "一饭的鸡扒饭曾经一度是我的最爱，这里的鸡扒饭窗口有鸡扒饭、奥尔良鸡扒饭、双拼鸡扒饭和猪扒饭等几种口味搭配，端到饭以后，可以选择在扒饭上面浇一些黑椒汁、咖喱汁、或者番茄汁，当然看个人口味的喜好了。同样，对于喜欢吃肉的小伙伴来说还是不错的。价位不是很贵，七到九元就可以端到饭，而且还附送饮料，是不是很赞",
        },
        new food_() {
          name_ = "面食",
          taste_ = "不辣/辣",
          species_ = "面食",
          price_ = "3-5元",
          price_max = 5,
          price_min = 3,
          score_ = 3,
          text_ = "这里是一饭的面食窗口，当然不是中大食堂里吃面食的最佳地点，不过对于想要偶尔更换一下口味的同学们来说，还是不错的选择。你可以选择炒面或者牛肉面，或者牛腩、鸡肉等为辅料的汤面，虽然分量比不上正常的米饭套餐，不过价格也相对便宜，只要4到5元就可以搞定了。夏天的时候这个窗口还会推出一款凉拌面，不过口味偏辛辣，各位量力而行。",
        },
        new food_() {
          name_ = "小笼包与蒸饺",
          taste_ = "不辣",
          species_ = "小食",
          price_ = "2.5-5元",
          price_max = 5,
          price_min = 2.5,
          score_ = 4,
          text_ = "一饭的小笼包与蒸饺是特色食品，深得大家喜爱。尤其是作为早餐，绝对是一个不错的选择。好吃不用说，关键是打包方便，价格实惠（一笼2.5元），每次去买都会排很长的队。如果你哪天觉得很饱吃不下太多的时候，可以试试来一笼。",
        },
        new food_() {
          name_ = "滑蛋饭窗口",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "7-9元",
          price_max = 9,
          price_min = 7,
          score_ = 4.5,
          text_ = "滑蛋饭也是一饭的一大特色。本人曾经一度十分怀疑这样做的饭会不会不好吃，会不会太干了，会不会蛋吃完了米饭还剩下大半。不过在尝试过一次以后，我发现自己多虑了，而且从此爱上了它。而且它种类很丰富，从鸡肉花单反、牛肉滑蛋饭到各种腊肠、蟹柳、虾仁等配料随你选，而且也可以浇黑椒汁、番茄汁或者咖喱汁，当然也附送一碗汤。你值得尝试一下。",
        },
        new food_() {
          name_ = "砂锅饭",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "6.5-8元",
          price_max = 8,
          price_min = 6.5,
          score_ = 3.5,
          text_ = "砂锅饭其实就是几样炒好的放在几个大砂锅里煮着的菜，用勺子浇在一盘饭上面。可以选择两个菜或者三个菜，个人觉得至少有一半的菜口味还是蛮好的，不过长期吃的话也许会觉得腻。价格也比较合理，6.5—8元的价位，看你选择的菜的种类多少定价。",
        },
        new food_() {
          name_ = "盖浇饭",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "7-8.5元",
          price_max = 8.5,
          price_min = 7,
          score_ = 3.5,
          text_ = "盖浇饭也是一种以米饭为主的主食，浇头多是鸡肉，有手撕鸡、炸鸡块、鸡腿、或者黑椒牛柳等等，不过这两年有分量越来越少的趋势。偶尔作为调节口味来吃，还是不错的。当然，与旁边的滑蛋饭窗口来比，不论是人流还是实惠程度，都差一些。",
        },
        new food_() {
          name_ = "一饭早餐",
          taste_ = "不辣",
          species_ = "小食",
          price_ = "3-6.5元",
          price_max = 6.5,
          price_min = 3,
          score_ = 3.5,
          text_ = "一饭的早餐窗口供应各种包子，有甜甜的叉烧包、也有吃起来怪怪的酸菜包，还有各种蛋糕（貌似一般好吃）和馒头，还有油条，炒粉之类的。总得来讲，吃的东西种类还算丰富，另外配有豆浆或者酸奶、牛奶等搭配，还算不错了，就是个别酸奶的价位可能小贵。",
        }
      };

    List<food_> listitems2 = new List<food_>()
      {
        new food_() {
          name_ = "套餐窗口",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "4-6元",
          price_max = 6,
          price_min = 4,
          score_ = 4,
          text_ = "二饭的套餐在四大食堂中是质量最高的，不论是菜的口感还是制作的精致程度都是。价格合理，4元5元6元的价位都有，方便选择。随套餐附送龟苓膏或者凉茶，在炎热的夏天也是十分棒的。当然分量对于大食量的小伙伴可能有点不够，不过可以加饭的啊，对不对。",
        },
        new food_() {
          name_ = "川菜窗口",
          taste_ = "辣",
          species_ = "米饭",
          price_ = "6元",
          price_max = 6,
          price_min = 6,
          score_ = 4,
          text_ = "这里的川菜窗口对于爱吃辣的同学来说算是福音了。整个中大的食堂，可以吃的辣菜是少之又少的（当然来久了，见到那么多好吃的，也就渐渐忘记辣椒这种东西了）。这里的窗口提供水煮牛肉、干煸豆角、麻婆豆腐、干炒牛筋丸等等的辣菜，味道还是不错的（当然有个别菜辣椒实在是多得受不了还是说一下），搭配饮料凉茶，用来降火。我的感觉是，在广东这个地方，辣的食物还是尽量不要常吃，否则是会上火的喔。",
        },
        new food_() {
          name_ = "西餐窗口",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "7-9元",
          price_max = 9,
          price_min = 7,
          score_ = 4,
          text_ = "西餐窗口这几年来都在不断地改变菜谱，不过也有几种饭深受大家喜爱，得以保留了下来。西餐窗口被点的最多的是西班牙鸡腿骨饭，鸡腿分量很足，还有西红柿鸡蛋搭配酸甜可口。另外有鸡扒的套餐也还不错，如果没有鸡腿饭的话也可以选鸡扒折中一下。另外西餐窗口现在还推出了芝士系列，个人觉得也很赞，只不过有个别的种类，番茄酱放的略多了，实在有点酸得难以忍受。价位嘛，7—9元的样子，也不是太贵。",
        },
        new food_() {
          name_ = "韩式风味定食",
          taste_ = "不辣/辣",
          species_ = "米饭",
          price_ = "7-9元",
          price_max = 9,
          price_min = 7,
          score_ = 4,
          text_ = "韩式风味的饭不论你选哪种，都有酸辣的泡菜作为搭配，这是最主要的。个人表示在吃多了泡菜以后觉得这个东西还是蛮好吃的，不过也有小伙伴会表示对于泡菜接受不能。个人觉得仁者见仁智者见智，不过韩式风味的窗口人气还是蛮不错的。可选的事物也有辣的或者不辣两种口味。这里最火爆的套餐是锅烧酱汁肉套餐。作为一种猎奇的心里存在，你可以试试它，相信用不了多久你就会喜欢上这个窗口的饭菜的。",
        },
        new food_() {
          name_ = "粉面类窗口",
          taste_ = "不辣",
          species_ = "面食",
          price_ = "3.5-5元",
          price_max = 5,
          price_min = 3.5,
          score_ = 3.5,
          text_ = "二饭的粉面类窗口是喜欢口味偏淡，食量偏小的人的最佳选择。在这里你可以选择面或者粉，配以云吞、木耳焖鸡、牛腩、牛丸或者直接做成炸酱面来吃，再配一碗汤。总之如果你是觉得很饿想要填饱肚子，那还是不要来这里吃了，如果你是这些天吃的有点油腻，想要挑换一下口味，那我想这里很适合你了。当然如果觉得分量少，还可以从旁边窗口拿一些小点心之类的来搭配，也是很不错的喔。",
        },
        new food_() {
          name_ = "糕点、小食类",
          taste_ = "不辣",
          species_ = "小食",
          price_ = "1.5-2.5元",
          price_max = 1.5,
          price_min = 2.5,
          score_ = 3.5,
          text_ = "如果你吃米饭吃腻了，然后吃面也吃腻了，那怎么办呢？如果你想要减肥，如果你想多吃一点健康的食物，吃一些粗粮，怎么办呢？我想这里可以提供你很多的好东西。比如，一些粥或者羹比如红薯、玉米、全麦面包等等。当然更多的情况下你可以作为与其它食物的搭配，因为你吃得不是很饱嘛对吧。嗯，学生都是很容易饿的，所以减肥的时候也不能饿到自己呀。",
        },
        new food_() {
          name_ = "夏日清凉套餐",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "7-9元",
          price_max = 9,
          price_min = 7,
          score_ = 4,
          text_ = "这个窗口是新开的一个窗口，专供各种炒饭或者炒米粉，可以选择鸡柳、虾仁、星洲炒米粉或者干炒牛河等等。当然最大的亮点是，这里的饭还提供红豆奶茶或者柠乐，所以在炎热的夏日还是很划算的，也很刺激食欲。价位在7—9元之间，相对实惠。",
        },
        new food_() {
          name_ = "二饭早餐",
          taste_ = "不辣",
          species_ = "小食",
          price_ = "3-5元",
          price_max = 5,
          price_min = 3,
          score_ = 4,
          text_ = "二饭的早餐与一饭是比较相似的，但是它有更好的粥点和豆浆，可以选择的食物也比较新鲜，很多还带着余热。总之，二饭是一个吃早餐的安静、舒适和干净的地方。",
        }
      };

    List<food_> listitems3 = new List<food_>()
      {
        new food_() {
          name_ = "炒饭、炒粉",
          taste_ = "不辣",
          species_ = "米饭/面食",
          price_ = "4-6",
          price_max = 6,
          price_min = 4,
          score_ = 3,
          text_ = "三饭的炒饭和炒粉并不一定是最好吃的，但是绝对是最方便的。它全天供应，不论是用来做中午饭还是夜宵，都不存在买不到的情况。特别适合那些过了饭点却又想要吃点东西的人。味道嘛，时好时坏，需要自己去体会咯。"
        },
        new food_() {
          name_ = "煲仔菜",
          taste_ = "不辣/辣",
          species_ = "米饭/小食",
          price_ = "6.5",
          price_max = 6.5,
          price_min = 6.5,
          score_ = 3.5,
          text_ = "这个窗口允许你选择三荤两素的菜品来烫着吃，可以加一分面，或者一碗米饭，辣椒什么的可以自己另外加，感觉还蛮实惠的样子，可以吃得很饱，价钱6.5也不算贵。"
        },
        new food_() {
          name_ = "肠粉",
          taste_ = "不辣",
          species_ = "小食",
          price_ = "3-5",
          price_max = 5,
          price_min = 3,
          score_ = 3.5,
          text_ = "三饭的肠粉有好几种不同的类别，作为一个北方人我尝试了以后觉得还是可以的，偶尔来换换口味还不错。"
        },
        new food_() {
          name_ = "麻辣烫",
          taste_ = "辣",
          species_ = "小食",
          price_ = "6-9",
          price_max = 9,
          price_min = 6,
          score_ = 3.5,
          text_ = "这算是各大食堂里为数不多的辣味了。麻辣烫的汤是用各种调料用汤调制出来的，然后自己可以选择几样菜、面、粉来搭配，就像麻辣烫通常情况下应该有的状况那样。不过因为师傅经常换的原因，偶尔调出来的汤会有点怪的味道。"
        },
        new food_() {
          name_ = "水饺、酸辣粉、火锅粉类",
          taste_ = "不辣/辣",
          species_ = "小食",
          price_ = "4-6",
          price_max = 6,
          price_min = 4,
          score_ = 3.5,
          text_ = "三饭的这个窗口，做出的东西还是蛮好吃的。不过酸辣粉的口味也确实很辣，而且水饺和火锅粉无疑烫得要死。如果你喜欢偶尔换换口味，吃一点辣的或者烫的，或者只是单纯地在冬天想暖暖身子，那么选择来一碗粉或者饺子，会很不错喔。当然价位比较合理，一般4—6元就可以拿下。不过需要注意，三饭的卫生条件和一饭、二饭比还是有差距的，偶尔吃吃可以，不推荐经常吃。"
        }
      };
    List<food_> listitems4 = new List<food_>()
      {
        new food_() {
          name_ = "鸡扒餐饭",
          taste_ = "不辣",
          species_ = "米饭/面食",
          price_ = "7.5-9.5",
          price_max = 9.5,
          price_min = 7.5,
          score_ = 4.5,
          text_ = "四饭的鸡扒饭是在四个饭堂中最有名的，因为不但有米饭，还有意粉可以选择搭配。同时，鸡扒的种类也可以多选，鸡扒饭分量很足。可以浇茄汁、番茄汁、咖喱、烧烤汁以及黑椒汁等多种搭配，满足不同口味同学的要求。"
        },
        new food_() {
          name_ = "自选窗口",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "5-10",
          price_max = 10,
          price_min = 5,
          score_ = 2.5,
          text_ = "四饭的自选窗口与一二饭的相比较，要单调得多。这里的自选饭菜，我们的推荐就是能吃饱就好，别想着会有多好吃的东西准备给你。自选对于四饭来说，纯粹就是为了丰富食堂的菜谱而存在的，所以如果不是赶时间的话，不推荐在这里选择它。"
        },
        new food_() {
          name_ = "煲仔饭",
          taste_ = "不辣",
          species_ = "米饭",
          price_ = "7-9",
          price_max = 9,
          price_min = 7,
          score_ = 4.5,
          text_ = "四饭的煲仔饭是属于比较有特色的食品之一，深得同学们喜爱。这里的煲仔饭都是现点现做，突出的就是一个新鲜。刚做好的煲仔饭腾腾地冒着热气，一不留神还会烫到吃饭心急的人。偶尔来吃的话，还是很不错的，推荐。"
        },
      };
    public food()
    {
      this.InitializeComponent();

      result.ItemsSource = listitems1;
    }
    private void Check1(object sender, RoutedEventArgs e)
    {
      if (result == null)
        result = new ListBox();
      if (result.ItemsSource != null)
        result.ItemsSource = listitems1;
    }

    private void Check2(object sender, RoutedEventArgs e)
    {
      if (result.ItemsSource != null)
        result.ItemsSource = listitems2;
    }

    private void Check3(object sender, RoutedEventArgs e)
    {
      if (result.ItemsSource != null)
        result.ItemsSource = listitems3;
    }

    private void Check4(object sender, RoutedEventArgs e)
    {
      if (result.ItemsSource != null)
        result.ItemsSource = listitems4;
    }

    private void search_click(object sender, RoutedEventArgs e)
    {
      List<food_> listitem_temp1 = new List<food_>();
      List<food_> listitem_temp2;
      if (rButton1.IsChecked == true)
        listitem_temp2 = listitems1;
      else if (rButton2.IsChecked == true)
        listitem_temp2 = listitems2;
      else if (rButton3.IsChecked == true)
        listitem_temp2 = listitems3;
      else if (rButton4.IsChecked == true)
        listitem_temp2 = listitems4;
      else
        listitem_temp2 = listitems1;

      for (int i = 0; i < listitem_temp2.Count; i++)
      {
        if (listitem_temp2[i].taste_ == comboBox1.SelectedItem.ToString() ||
          listitem_temp2[i].taste_ == "不辣/辣" || comboBox1.SelectedItem.ToString() == "全部")
        {
          if (listitem_temp2[i].species_ == comboBox2.SelectedItem.ToString() ||
            comboBox2.SelectedItem.ToString() == "全部")
          {
            if (listitem_temp2[i].score_.ToString() == comboBox4.SelectedItem.ToString() ||
              comboBox4.SelectedItem.ToString() == "全部")
            {
              if (comboBox3.SelectedItem.ToString() == "全部")
              {
                listitem_temp1.Add(listitem_temp2[i]);
              }
              else if (comboBox3.SelectedItem.ToString() == "<6元")
              {
                if (listitem_temp2[i].price_max < 6)
                  listitem_temp1.Add(listitem_temp2[i]);
              }
              else if (comboBox3.SelectedItem.ToString() == "6--9元") {
                if (listitem_temp2[i].price_max <= 9 || listitem_temp2[i].price_min <= 6)
                  listitem_temp1.Add(listitem_temp2[i]);
              }
              else if (comboBox3.SelectedItem.ToString() == ">9元")
              {
                if (listitem_temp2[i].price_min > 9)
                  listitem_temp1.Add(listitem_temp2[i]);
              }
            }
          }
        }
      }

      result.ItemsSource = listitem_temp1;
    }

    private void AppBarButton_Home(object sender, RoutedEventArgs e)
    {
      this.Frame.Navigate(typeof(MainPage));
    }

    private void AppBarButton_Back(object sender, RoutedEventArgs e)
    {
      this.Frame.Navigate(typeof(EastCampus));
    }


  }
}
