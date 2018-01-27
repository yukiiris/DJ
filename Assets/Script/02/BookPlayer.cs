﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookPlayer : MonoBehaviour
{

    public Text title;
    public Text content;
    public bool isReadingBook=false;
    #region  书的内容  一大串  
    private string book_1 =
        "《工人保尔（一）》：\n" +
        "这次为大家带来的是这个月的畅销书《工人保尔》。下面是读者们选出最感人的段落。故事正到，保尔守着铁路口寻找逃跑的工人，却遇到了他的旧识，夏尔莎。\n" +
        "保尔粗暴地抓住那人的肩膀，一下子把那人掀翻在地。那个工人栽在雪地里，挣扎地翻过身，露出巨大鸭舌帽下的面容。\n" +
        "帽子下的金发混杂着雪，让保尔一下回忆起十年前的那个冬天。那时的那个女孩，也是摔倒在雪地里，一头金发沾满白雪。\n" +
        "虽然时光和疲劳让她的面容憔悴枯黄，但保尔永远不会忘记那个和自己定下约定的女孩，就像他不会忘记自己对真理的热爱一样。\n" +
        "“是你。”保尔错愕，“夏尔莎。”\n" +
        "“对，是我。”眼前人开了口，死死地盯着保尔。\n" +
        "“真理之父在上，我没有想到竟然是你。”保尔也没有想到自己的青梅竹马竟然选择如此堕落，“你加入了隐知会。”\n" +
        "“这就是我的选择，保尔。” 夏尔莎泣不成声，“你不能理解吗？”\n" +
        "”为什么？”保尔失望地转身，“这就是你们追求的自由吗？这就是所谓的自由吗？！”\n" +
        "“你什么都不懂！”她逃跑了。\n" +
        "保尔陷入了天人交战——我应该去追吗？我应该放过这个罪犯吗？\n" +
        "虽然保尔如此纠结痛苦，但是真理之父在上，我们相信他一定会克服私心，为了真理将犯人抓回。\n" +
        "今天的荐书《工人保尔》就到这里，想看后文的听众们可以去思想进步门下的书店申请购买哦。";
    private string book_2 =
        "《真理报》：\n" +
        "今天为大家带来的是今日《真理报》的特别选段，由文化宣传门首席真理之子推荐！\n" +
        "正如《真理之父》开篇所言：“真理是不惧一切的巨熊，真理是碾压一切的铁骑，真理是超越一切的永恒。”\n" +
        "我们需要知道真理是如此伟大，以至于它不需要拥护就能战胜一切强敌。可是我们依然不自觉地主动地选择追寻真理，选择维护真理。\n" +
        "这是为什么？是因为真理之父为它代言吗？是因为成为真理之子是无上荣耀吗？都不是！\n" +
        "是真理选择了我们！它即是巨熊，它即是铁骑，它即是永恒，它即是一切！它选择了我们！那么我们就将为它奉献一切！\n" +
        "咳咳，不好意思有些激动，那么今天的荐文就到这里啦。欢迎来电真理之光订购全年份的《真理报增刊》，大家说不定可以从中找到和《真理报》不一样的阅读体验哦。";

    private string book_3 =
        "《我们的尤利亚》：\n" +
        "今天为大家带来的是这本老少咸宜的《我们的尤利亚》，作为一本科普书籍，它又能为带来什么呢？\n" +
        "众所周知，我们生活在艾波图大陆上，而这块大陆上有三个国家，托利亚，皮利亚，以及我们伟大的祖国尤利亚。\n" +
        "最初的最初，有一群智慧而自由的人们，他们带领我们的祖先建立起这个美丽的国度，尤利亚。\n" +
        "如今的我们，在那七位——也就是真理之父——的引领下，为了追寻真理，维护真理而不断奋斗，对抗敌人。\n" +
        "为了真理，我们建立起完美的社会制度。由真理之父引领最高真理之厅——第一真理之子们。\n" +
        "而真理之子们又管理着真理政府，下属有真理部（文化宣传门，思想进步门，教育门等），民事部（团结门，公共安全门等），建设部，进步部（外交门，国家安全门等）等。\n" +
        "它们一致对外，坚守真理，是我们国家最重要的部分。\n" +
        "这本书相信大家都多少看过，可以说是非常棒的一本启蒙书了。如果有家庭需要，可以直接在最近的宣传站领取到。\n";
    private string book_4 =
        "《谢·伊金诗歌选》：\n" +
        "今天为大家带来的书是著名诗人谢·伊金的诗歌集。这位伟大的真理追寻者，为如今的真理理论奠定了基础。\n" +
        "但是在你孤独，悲伤的日子/请你大声地喊出真理之名/并且说：真理在庇护我，在世间我活在真理的照耀下。\n" +
        "假如谎言欺骗了你/不要悲伤，不要心急！/\n" +
        "悲伤的日子里需要真理/相信吧，伟大的真理将会来临！/\n" +
        "心儿永远向往着真理 /现在却常是迷茫/\n" +
        "一切都是瞬息，一切都将会过去/而那过去了的，就会成为通往真理的基石。\n" +
        "听过这些，大家有没有觉得生活变得更加充实了呢？这本书也可以在思想进步门的书店买到哦。";
    private string book_5 =
        "《真理宣言》:\n" +
        "今天为大家带来的是举世闻名的《真理宣言》，由著名真理家马·里泰撰写。\n" +
        "一个幽灵，无上真理的幽灵，在艾波图大陆徘徊。为了对这个幽灵进行卑鄙的围剿，谎言和谬论，专制和封建，都联合起来了。\n" +
        "有哪一个真理党不被它的当政的敌人称作危险的谎言呢？又有哪一个反对党不拿谎言这个罪名去回敬更进步的真理党人呢？\n" +
        "从这一事实中可以得到一个结论：\n" +
        "真理党为那些反智群体所恐惧，但那些反智群体又知道真理不可被自己拥有，所以只得用谎言去构筑虚假的真理。\n" +
        "现在是真理党人向全世界公开说明自己的观点、自己的目的、自己的意图并且拿党自己的宣言来反驳关于真理幽灵的神话的时候了。\n" +
        "这本宣言是真理党第一份国际性纲领文件，开启了真理党站在世界舞台上追寻真理的时代。那么今天的选读到此为止。\n";
    private string book_6 =
        "《工人保尔（二）》:\n" +
        "这次为大家带来的依旧是畅销书《工人保尔》的选段。这次故事到保尔带领建设部铁道门的工人们成功修建好了最后一段铁路，正在大开庆功宴。\n" +
        "吉鲁特城外的一个小酒馆里，灯火通明，欢声笑语。\n" +
        "“同志！伏特卡！”老斯卡夫捷斯基一把搭住保尔的肩膀，把巨大的酒杯推到保尔脸边。那是足足半理升的伏特卡，足以灌醉半头牛。\n" +
        "“你喝太多了，斯卡夫。”保尔留意到他起码已经喝了三杯了。\n" +
        "“今，嗝，今天可是胜利的日子！”斯卡夫捷斯基开始灌起第四杯，“真理之父在上，让我醉死在这里吧！”\n" +
        "“那可不行，斯卡夫，你还要继续为建设部奉献自己呢。”保尔笑着说，心情也是轻松愉快。\n" +
        "“追寻真理！维护真理！”人群里有人喊道。\n" +
        "“追寻真理！维护真理！”保尔跟着喊道，不禁感到自己充满了力量。\n" +
        "是的，只是这样两句口号就能让人充满力量，这就是真理的伟大力量。今天的选读就到这里。";
    private string book_7 =
        "《隐知之恶》:\n" +
        "相信大家现在也很关心前几天的隐知会究竟是怎么回事，今天为大家带来的就是关于这个邪恶组织的《隐知之恶》。\n" +
        "隐知会旨在隐藏真理，让世人被谎言蒙蔽。创立时间不明，创始人被他们组织称作“余”。\n" +
        "自我国建国至今，隐知会已经几次策动反智之人，企图颠覆伟大的真理政权，但都被我们优秀的国家安全门真理之子所粉碎。\n" +
        "与我党的标识——一只睁着的眼——相反，他们的标识是一只闭着的眼，可谓十分邪恶。他们蔑视真理，认为真理是相对的。\n" +
        "希望大家可以通过这本书了解到我们面对的是怎样一个邪恶的组织，坚决与其划清界限，坚决拥护真理党，追寻真理，维护真理！";
    #endregion
    private void OnTriggerStay(Collider other)
    {
        other.transform.gameObject.GetComponent<Book>().isUsed = true;
        if (!other.transform.gameObject.GetComponent<Book>().isClicked)
        {
            other.transform.position = new Vector3(10, 10, 0);
            title.text = other.transform.GetComponent<Book>().title;
            content.text = other.transform.GetComponent<Book>().info;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.gameObject.GetComponent<Book>().isUsed = false;
    }
}
