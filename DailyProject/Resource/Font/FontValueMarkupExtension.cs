using System;
using System.Reflection;
using System.Windows.Markup;

namespace DailyProject
{
    class FontValueMarkupExtension : MarkupExtension
    {
        public FontValueMarkupExtension ()
        {
        }

        public FontDescription Font { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var charactor = typeof(FontDescription).GetField(Font.ToString())
                                .GetCustomAttribute<CharAttribute>()
                                .Value;

            return charactor.ToString();
        }
    }


    [AttributeUsage(AttributeTargets.Field)]
    sealed class CharAttribute : Attribute
    {
        public char Value { get; private set; }

        public CharAttribute(char value)
        {
            this.Value = value;
        }
    }

    enum FontDescription
    {

        [Char('\uf042')]
        Adjust,

        [Char('\uf170')]
        Adn,

        [Char('\uf037')]
        AlignCenter,

        [Char('\uf039')]
        AlignJustify,

        [Char('\uf036')]
        AlignLeft,

        [Char('\uf038')]
        AlignRight,

        [Char('\uf0f9')]
        Ambulance,

        [Char('\uf13d')]
        Anchor,

        [Char('\uf17b')]
        Android,

        [Char('\uf209')]
        Angellist,

        [Char('\uf103')]
        AngleDoubleDown,

        [Char('\uf100')]
        AngleDoubleLeft,

        [Char('\uf101')]
        AngleDoubleRight,

        [Char('\uf102')]
        AngleDoubleUp,

        [Char('\uf107')]
        AngleDown,

        [Char('\uf104')]
        AngleLeft,

        [Char('\uf105')]
        AngleRight,

        [Char('\uf106')]
        AngleUp,

        [Char('\uf179')]
        Apple,

        [Char('\uf187')]
        Archive,

        [Char('\uf1fe')]
        AreaChart,

        [Char('\uf0ab')]
        ArrowCircleDown,

        [Char('\uf0a8')]
        ArrowCircleLeft,

        [Char('\uf01a')]
        ArrowCircleODown,

        [Char('\uf190')]
        ArrowCircleOLeft,

        [Char('\uf18e')]
        ArrowCircleORight,

        [Char('\uf01b')]
        ArrowCircleOUp,

        [Char('\uf0a9')]
        ArrowCircleRight,

        [Char('\uf0aa')]
        ArrowCircleUp,

        [Char('\uf063')]
        ArrowDown,

        [Char('\uf060')]
        ArrowLeft,

        [Char('\uf061')]
        ArrowRight,

        [Char('\uf062')]
        ArrowUp,

        [Char('\uf047')]
        Arrows,

        [Char('\uf0b2')]
        ArrowsAlt,

        [Char('\uf07e')]
        ArrowsH,

        [Char('\uf07d')]
        ArrowsV,

        [Char('\uf069')]
        Asterisk,

        [Char('\uf1fa')]
        At,

        [Char('\uf1b9')]
        Automobile,

        [Char('\uf04a')]
        Backward,

        [Char('\uf05e')]
        Ban,

        [Char('\uf19c')]
        Bank,

        [Char('\uf080')]
        BarChart,

        [Char('\uf080')]
        BarChartO,

        [Char('\uf02a')]
        Barcode,

        [Char('\uf0c9')]
        Bars,

        [Char('\uf236')]
        Bed,

        [Char('\uf0fc')]
        Beer,

        [Char('\uf1b4')]
        Behance,

        [Char('\uf1b5')]
        BehanceSquare,

        [Char('\uf0f3')]
        Bell,

        [Char('\uf0a2')]
        BellO,

        [Char('\uf1f6')]
        BellSlash,

        [Char('\uf1f7')]
        BellSlashO,

        [Char('\uf206')]
        Bicycle,

        [Char('\uf1e5')]
        Binoculars,

        [Char('\uf1fd')]
        BirthdayCake,

        [Char('\uf171')]
        Bitbucket,

        [Char('\uf172')]
        BitbucketSquare,

        [Char('\uf15a')]
        Bitcoin,

        [Char('\uf032')]
        Bold,

        [Char('\uf0e7')]
        Bolt,

        [Char('\uf1e2')]
        Bomb,

        [Char('\uf02d')]
        Book,

        [Char('\uf02e')]
        Bookmark,

        [Char('\uf097')]
        BookmarkO,

        [Char('\uf0b1')]
        Briefcase,

        [Char('\uf15a')]
        Btc,

        [Char('\uf188')]
        Bug,

        [Char('\uf1ad')]
        Building,

        [Char('\uf0f7')]
        BuildingO,

        [Char('\uf0a1')]
        Bullhorn,

        [Char('\uf140')]
        Bullseye,

        [Char('\uf207')]
        Bus,

        [Char('\uf20d')]
        Buysellads,

        [Char('\uf1ba')]
        Cab,

        [Char('\uf1ec')]
        Calculator,

        [Char('\uf073')]
        Calendar,

        [Char('\uf133')]
        CalendarO,

        [Char('\uf030')]
        Camera,

        [Char('\uf083')]
        CameraRetro,

        [Char('\uf1b9')]
        Car,

        [Char('\uf0d7')]
        CaretDown,

        [Char('\uf0d9')]
        CaretLeft,

        [Char('\uf0da')]
        CaretRight,

        [Char('\uf150')]
        CaretSquareODown,

        [Char('\uf191')]
        CaretSquareOLeft,

        [Char('\uf152')]
        CaretSquareORight,

        [Char('\uf151')]
        CaretSquareOUp,

        [Char('\uf0d8')]
        CaretUp,

        [Char('\uf218')]
        CartArrowDown,

        [Char('\uf217')]
        CartPlus,

        [Char('\uf20a')]
        Cc,

        [Char('\uf1f3')]
        CcAmex,

        [Char('\uf1f2')]
        CcDiscover,

        [Char('\uf1f1')]
        CcMastercard,

        [Char('\uf1f4')]
        CcPaypal,

        [Char('\uf1f5')]
        CcStripe,

        [Char('\uf1f0')]
        CcVisa,

        [Char('\uf0a3')]
        Certificate,

        [Char('\uf0c1')]
        Chain,

        [Char('\uf127')]
        ChainBroken,

        [Char('\uf00c')]
        Check,

        [Char('\uf058')]
        CheckCircle,

        [Char('\uf05d')]
        CheckCircleO,

        [Char('\uf14a')]
        CheckSquare,

        [Char('\uf046')]
        CheckSquareO,

        [Char('\uf13a')]
        ChevronCircleDown,

        [Char('\uf137')]
        ChevronCircleLeft,

        [Char('\uf138')]
        ChevronCircleRight,

        [Char('\uf139')]
        ChevronCircleUp,

        [Char('\uf078')]
        ChevronDown,

        [Char('\uf053')]
        ChevronLeft,

        [Char('\uf054')]
        ChevronRight,

        [Char('\uf077')]
        ChevronUp,

        [Char('\uf1ae')]
        Child,

        [Char('\uf111')]
        Circle,

        [Char('\uf10c')]
        CircleO,

        [Char('\uf1ce')]
        CircleONotch,

        [Char('\uf1db')]
        CircleThin,

        [Char('\uf0ea')]
        Clipboard,

        [Char('\uf017')]
        ClockO,

        [Char('\uf00d')]
        Close,

        [Char('\uf0c2')]
        Cloud,

        [Char('\uf0ed')]
        CloudDownload,

        [Char('\uf0ee')]
        CloudUpload,

        [Char('\uf157')]
        Cny,

        [Char('\uf121')]
        Code,

        [Char('\uf126')]
        CodeFork,

        [Char('\uf1cb')]
        Codepen,

        [Char('\uf0f4')]
        Coffee,

        [Char('\uf013')]
        Cog,

        [Char('\uf085')]
        Cogs,

        [Char('\uf0db')]
        Columns,

        [Char('\uf075')]
        Comment,

        [Char('\uf0e5')]
        CommentO,

        [Char('\uf086')]
        Comments,

        [Char('\uf0e6')]
        CommentsO,

        [Char('\uf14e')]
        Compass,

        [Char('\uf066')]
        Compress,

        [Char('\uf20e')]
        Connectdevelop,

        [Char('\uf0c5')]
        Copy,

        [Char('\uf1f9')]
        Copyright,

        [Char('\uf09d')]
        CreditCard,

        [Char('\uf125')]
        Crop,

        [Char('\uf05b')]
        Crosshairs,

        [Char('\uf13c')]
        Css3,

        [Char('\uf1b2')]
        Cube,

        [Char('\uf1b3')]
        Cubes,

        [Char('\uf0c4')]
        Cut,

        [Char('\uf0f5')]
        Cutlery,

        [Char('\uf0e4')]
        Dashboard,

        [Char('\uf210')]
        Dashcube,

        [Char('\uf1c0')]
        Database,

        [Char('\uf03b')]
        Dedent,

        [Char('\uf1a5')]
        Delicious,

        [Char('\uf108')]
        Desktop,

        [Char('\uf1bd')]
        Deviantart,

        [Char('\uf219')]
        Diamond,

        [Char('\uf1a6')]
        Digg,

        [Char('\uf155')]
        Dollar,

        [Char('\uf192')]
        DotCircleO,

        [Char('\uf019')]
        Download,

        [Char('\uf17d')]
        Dribbble,

        [Char('\uf16b')]
        Dropbox,

        [Char('\uf1a9')]
        Drupal,

        [Char('\uf044')]
        Edit,

        [Char('\uf052')]
        Eject,

        [Char('\uf141')]
        EllipsisH,

        [Char('\uf142')]
        EllipsisV,

        [Char('\uf1d1')]
        Empire,

        [Char('\uf0e0')]
        Envelope,

        [Char('\uf003')]
        EnvelopeO,

        [Char('\uf199')]
        EnvelopeSquare,

        [Char('\uf12d')]
        Eraser,

        [Char('\uf153')]
        Eur,

        [Char('\uf153')]
        Euro,

        [Char('\uf0ec')]
        Exchange,

        [Char('\uf12a')]
        Exclamation,

        [Char('\uf06a')]
        ExclamationCircle,

        [Char('\uf071')]
        ExclamationTriangle,

        [Char('\uf065')]
        Expand,

        [Char('\uf08e')]
        ExternalLink,

        [Char('\uf14c')]
        ExternalLinkSquare,

        [Char('\uf06e')]
        Eye,

        [Char('\uf070')]
        EyeSlash,

        [Char('\uf1fb')]
        Eyedropper,

        [Char('\uf09a')]
        Facebook,

        [Char('\uf09a')]
        FacebookF,

        [Char('\uf230')]
        FacebookOfficial,

        [Char('\uf082')]
        FacebookSquare,

        [Char('\uf049')]
        FastBackward,

        [Char('\uf050')]
        FastForward,

        [Char('\uf1ac')]
        Fax,

        [Char('\uf182')]
        Female,

        [Char('\uf0fb')]
        FighterJet,

        [Char('\uf15b')]
        File,

        [Char('\uf1c6')]
        FileArchiveO,

        [Char('\uf1c7')]
        FileAudioO,

        [Char('\uf1c9')]
        FileCodeO,

        [Char('\uf1c3')]
        FileExcelO,

        [Char('\uf1c5')]
        FileImageO,

        [Char('\uf1c8')]
        FileMovieO,

        [Char('\uf016')]
        FileO,

        [Char('\uf1c1')]
        FilePdfO,

        [Char('\uf1c5')]
        FilePhotoO,

        [Char('\uf1c5')]
        FilePictureO,

        [Char('\uf1c4')]
        FilePowerpointO,

        [Char('\uf1c7')]
        FileSoundO,

        [Char('\uf15c')]
        FileText,

        [Char('\uf0f6')]
        FileTextO,

        [Char('\uf1c8')]
        FileVideoO,

        [Char('\uf1c2')]
        FileWordO,

        [Char('\uf1c6')]
        FileZipO,

        [Char('\uf0c5')]
        FilesO,

        [Char('\uf008')]
        Film,

        [Char('\uf0b0')]
        Filter,

        [Char('\uf06d')]
        Fire,

        [Char('\uf134')]
        FireExtinguisher,

        [Char('\uf024')]
        Flag,

        [Char('\uf11e')]
        FlagCheckered,

        [Char('\uf11d')]
        FlagO,

        [Char('\uf0e7')]
        Flash,

        [Char('\uf0c3')]
        Flask,

        [Char('\uf16e')]
        Flickr,

        [Char('\uf0c7')]
        FloppyO,

        [Char('\uf07b')]
        Folder,

        [Char('\uf114')]
        FolderO,

        [Char('\uf07c')]
        FolderOpen,

        [Char('\uf115')]
        FolderOpenO,

        [Char('\uf031')]
        Font,

        [Char('\uf211')]
        Forumbee,

        [Char('\uf04e')]
        Forward,

        [Char('\uf180')]
        Foursquare,

        [Char('\uf119')]
        FrownO,

        [Char('\uf1e3')]
        FutbolO,

        [Char('\uf11b')]
        Gamepad,

        [Char('\uf0e3')]
        Gavel,

        [Char('\uf154')]
        Gbp,

        [Char('\uf1d1')]
        Ge,

        [Char('\uf013')]
        Gear,

        [Char('\uf085')]
        Gears,

        [Char('\uf1db')]
        Genderless,

        [Char('\uf06b')]
        Gift,

        [Char('\uf1d3')]
        Git,

        [Char('\uf1d2')]
        GitSquare,

        [Char('\uf09b')]
        Github,

        [Char('\uf113')]
        GithubAlt,

        [Char('\uf092')]
        GithubSquare,

        [Char('\uf184')]
        Gittip,

        [Char('\uf000')]
        Glass,

        [Char('\uf0ac')]
        Globe,

        [Char('\uf1a0')]
        Google,

        [Char('\uf0d5')]
        GooglePlus,

        [Char('\uf0d4')]
        GooglePlusSquare,

        [Char('\uf1ee')]
        GoogleWallet,

        [Char('\uf19d')]
        GraduationCap,

        [Char('\uf184')]
        Gratipay,

        [Char('\uf0c0')]
        Group,

        [Char('\uf0fd')]
        HSquare,

        [Char('\uf1d4')]
        HackerNews,

        [Char('\uf0a7')]
        HandODown,

        [Char('\uf0a5')]
        HandOLeft,

        [Char('\uf0a4')]
        HandORight,

        [Char('\uf0a6')]
        HandOUp,

        [Char('\uf0a0')]
        HddO,

        [Char('\uf1dc')]
        Header,

        [Char('\uf025')]
        Headphones,

        [Char('\uf004')]
        Heart,

        [Char('\uf08a')]
        HeartO,

        [Char('\uf21e')]
        Heartbeat,

        [Char('\uf1da')]
        History,

        [Char('\uf015')]
        Home,

        [Char('\uf0f8')]
        HospitalO,

        [Char('\uf236')]
        Hotel,

        [Char('\uf13b')]
        Html5,

        [Char('\uf20b')]
        Ils,

        [Char('\uf03e')]
        Image,

        [Char('\uf01c')]
        Inbox,

        [Char('\uf03c')]
        Indent,

        [Char('\uf129')]
        Info,

        [Char('\uf05a')]
        InfoCircle,

        [Char('\uf156')]
        Inr,

        [Char('\uf16d')]
        Instagram,

        [Char('\uf19c')]
        Institution,

        [Char('\uf208')]
        Ioxhost,

        [Char('\uf033')]
        Italic,

        [Char('\uf1aa')]
        Joomla,

        [Char('\uf157')]
        Jpy,

        [Char('\uf1cc')]
        Jsfiddle,

        [Char('\uf084')]
        Key,

        [Char('\uf11c')]
        KeyboardO,

        [Char('\uf159')]
        Krw,

        [Char('\uf1ab')]
        Language,

        [Char('\uf109')]
        Laptop,

        [Char('\uf202')]
        Lastfm,

        [Char('\uf203')]
        LastfmSquare,

        [Char('\uf06c')]
        Leaf,

        [Char('\uf212')]
        Leanpub,

        [Char('\uf0e3')]
        Legal,

        [Char('\uf094')]
        LemonO,

        [Char('\uf149')]
        LevelDown,

        [Char('\uf148')]
        LevelUp,

        [Char('\uf1cd')]
        LifeBouy,

        [Char('\uf1cd')]
        LifeBuoy,

        [Char('\uf1cd')]
        LifeRing,

        [Char('\uf1cd')]
        LifeSaver,

        [Char('\uf0eb')]
        LightbulbO,

        [Char('\uf201')]
        LineChart,

        [Char('\uf0c1')]
        Link,

        [Char('\uf0e1')]
        Linkedin,

        [Char('\uf08c')]
        LinkedinSquare,

        [Char('\uf17c')]
        Linux,

        [Char('\uf03a')]
        List,

        [Char('\uf022')]
        ListAlt,

        [Char('\uf0cb')]
        ListOl,

        [Char('\uf0ca')]
        ListUl,

        [Char('\uf124')]
        LocationArrow,

        [Char('\uf023')]
        Lock,

        [Char('\uf175')]
        LongArrowDown,

        [Char('\uf177')]
        LongArrowLeft,

        [Char('\uf178')]
        LongArrowRight,

        [Char('\uf176')]
        LongArrowUp,

        [Char('\uf0d0')]
        Magic,

        [Char('\uf076')]
        Magnet,

        [Char('\uf064')]
        MailForward,

        [Char('\uf112')]
        MailReply,

        [Char('\uf122')]
        MailReplyAll,

        [Char('\uf183')]
        Male,

        [Char('\uf041')]
        MapMarker,

        [Char('\uf222')]
        Mars,

        [Char('\uf227')]
        MarsDouble,

        [Char('\uf229')]
        MarsStroke,

        [Char('\uf22b')]
        MarsStrokeH,

        [Char('\uf22a')]
        MarsStrokeV,

        [Char('\uf136')]
        Maxcdn,

        [Char('\uf20c')]
        Meanpath,

        [Char('\uf23a')]
        Medium,

        [Char('\uf0fa')]
        Medkit,

        [Char('\uf11a')]
        MehO,

        [Char('\uf223')]
        Mercury,

        [Char('\uf130')]
        Microphone,

        [Char('\uf131')]
        MicrophoneSlash,

        [Char('\uf068')]
        Minus,

        [Char('\uf056')]
        MinusCircle,

        [Char('\uf146')]
        MinusSquare,

        [Char('\uf147')]
        MinusSquareO,

        [Char('\uf10b')]
        Mobile,

        [Char('\uf10b')]
        MobilePhone,

        [Char('\uf0d6')]
        Money,

        [Char('\uf186')]
        MoonO,

        [Char('\uf19d')]
        MortarBoard,

        [Char('\uf21c')]
        Motorcycle,

        [Char('\uf001')]
        Music,

        [Char('\uf0c9')]
        Navicon,

        [Char('\uf22c')]
        Neuter,

        [Char('\uf1ea')]
        NewspaperO,

        [Char('\uf19b')]
        Openid,

        [Char('\uf03b')]
        Outdent,

        [Char('\uf18c')]
        Pagelines,

        [Char('\uf1fc')]
        PaintBrush,

        [Char('\uf1d8')]
        PaperPlane,

        [Char('\uf1d9')]
        PaperPlaneO,

        [Char('\uf0c6')]
        Paperclip,

        [Char('\uf1dd')]
        Paragraph,

        [Char('\uf0ea')]
        Paste,

        [Char('\uf04c')]
        Pause,

        [Char('\uf1b0')]
        Paw,

        [Char('\uf1ed')]
        Paypal,

        [Char('\uf040')]
        Pencil,

        [Char('\uf14b')]
        PencilSquare,

        [Char('\uf044')]
        PencilSquareO,

        [Char('\uf095')]
        Phone,

        [Char('\uf098')]
        PhoneSquare,

        [Char('\uf03e')]
        Photo,

        [Char('\uf03e')]
        PictureO,

        [Char('\uf200')]
        PieChart,

        [Char('\uf1a7')]
        PiedPiper,

        [Char('\uf1a8')]
        PiedPiperAlt,

        [Char('\uf0d2')]
        Pinterest,

        [Char('\uf231')]
        PinterestP,

        [Char('\uf0d3')]
        PinterestSquare,

        [Char('\uf072')]
        Plane,

        [Char('\uf04b')]
        Play,

        [Char('\uf144')]
        PlayCircle,

        [Char('\uf01d')]
        PlayCircleO,

        [Char('\uf1e6')]
        Plug,

        [Char('\uf067')]
        Plus,

        [Char('\uf055')]
        PlusCircle,

        [Char('\uf0fe')]
        PlusSquare,

        [Char('\uf196')]
        PlusSquareO,

        [Char('\uf011')]
        PowerOff,

        [Char('\uf02f')]
        Print,

        [Char('\uf12e')]
        PuzzlePiece,

        [Char('\uf1d6')]
        Qq,

        [Char('\uf029')]
        Qrcode,

        [Char('\uf128')]
        Question,

        [Char('\uf059')]
        QuestionCircle,

        [Char('\uf10d')]
        QuoteLeft,

        [Char('\uf10e')]
        QuoteRight,

        [Char('\uf1d0')]
        Ra,

        [Char('\uf074')]
        Random,

        [Char('\uf1d0')]
        Rebel,

        [Char('\uf1b8')]
        Recycle,

        [Char('\uf1a1')]
        Reddit,

        [Char('\uf1a2')]
        RedditSquare,

        [Char('\uf021')]
        Refresh,

        [Char('\uf00d')]
        Remove,

        [Char('\uf18b')]
        Renren,

        [Char('\uf0c9')]
        Reorder,

        [Char('\uf01e')]
        Repeat,

        [Char('\uf112')]
        Reply,

        [Char('\uf122')]
        ReplyAll,

        [Char('\uf079')]
        Retweet,

        [Char('\uf157')]
        Rmb,

        [Char('\uf018')]
        Road,

        [Char('\uf135')]
        Rocket,

        [Char('\uf0e2')]
        RotateLeft,

        [Char('\uf01e')]
        RotateRight,

        [Char('\uf158')]
        Rouble,

        [Char('\uf09e')]
        Rss,

        [Char('\uf143')]
        RssSquare,

        [Char('\uf158')]
        Rub,

        [Char('\uf158')]
        Ruble,

        [Char('\uf156')]
        Rupee,

        [Char('\uf0c7')]
        Save,

        [Char('\uf0c4')]
        Scissors,

        [Char('\uf002')]
        Search,

        [Char('\uf010')]
        SearchMinus,

        [Char('\uf00e')]
        SearchPlus,

        [Char('\uf213')]
        Sellsy,

        [Char('\uf1d8')]
        Send,

        [Char('\uf1d9')]
        SendO,

        [Char('\uf233')]
        Server,

        [Char('\uf064')]
        Share,

        [Char('\uf1e0')]
        ShareAlt,

        [Char('\uf1e1')]
        ShareAltSquare,

        [Char('\uf14d')]
        ShareSquare,

        [Char('\uf045')]
        ShareSquareO,

        [Char('\uf20b')]
        Shekel,

        [Char('\uf20b')]
        Sheqel,

        [Char('\uf132')]
        Shield,

        [Char('\uf21a')]
        Ship,

        [Char('\uf214')]
        Shirtsinbulk,

        [Char('\uf07a')]
        ShoppingCart,

        [Char('\uf090')]
        SignIn,

        [Char('\uf08b')]
        SignOut,

        [Char('\uf012')]
        Signal,

        [Char('\uf215')]
        Simplybuilt,

        [Char('\uf0e8')]
        Sitemap,

        [Char('\uf216')]
        Skyatlas,

        [Char('\uf17e')]
        Skype,

        [Char('\uf198')]
        Slack,

        [Char('\uf1de')]
        Sliders,

        [Char('\uf1e7')]
        Slideshare,

        [Char('\uf118')]
        SmileO,

        [Char('\uf1e3')]
        SoccerBallO,

        [Char('\uf0dc')]
        Sort,

        [Char('\uf15d')]
        SortAlphaAsc,

        [Char('\uf15e')]
        SortAlphaDesc,

        [Char('\uf160')]
        SortAmountAsc,

        [Char('\uf161')]
        SortAmountDesc,

        [Char('\uf0de')]
        SortAsc,

        [Char('\uf0dd')]
        SortDesc,

        [Char('\uf0dd')]
        SortDown,

        [Char('\uf162')]
        SortNumericAsc,

        [Char('\uf163')]
        SortNumericDesc,

        [Char('\uf0de')]
        SortUp,

        [Char('\uf1be')]
        Soundcloud,

        [Char('\uf197')]
        SpaceShuttle,

        [Char('\uf110')]
        Spinner,

        [Char('\uf1b1')]
        Spoon,

        [Char('\uf1bc')]
        Spotify,

        [Char('\uf0c8')]
        Square,

        [Char('\uf096')]
        SquareO,

        [Char('\uf18d')]
        StackExchange,

        [Char('\uf16c')]
        StackOverflow,

        [Char('\uf005')]
        Star,

        [Char('\uf089')]
        StarHalf,

        [Char('\uf123')]
        StarHalfEmpty,

        [Char('\uf123')]
        StarHalfFull,

        [Char('\uf123')]
        StarHalfO,

        [Char('\uf006')]
        StarO,

        [Char('\uf1b6')]
        Steam,

        [Char('\uf1b7')]
        SteamSquare,

        [Char('\uf048')]
        StepBackward,

        [Char('\uf051')]
        StepForward,

        [Char('\uf0f1')]
        Stethoscope,

        [Char('\uf04d')]
        Stop,

        [Char('\uf21d')]
        StreetView,

        [Char('\uf0cc')]
        Strikethrough,

        [Char('\uf1a4')]
        Stumbleupon,

        [Char('\uf1a3')]
        StumbleuponCircle,

        [Char('\uf12c')]
        Subscript,

        [Char('\uf239')]
        Subway,

        [Char('\uf0f2')]
        Suitcase,

        [Char('\uf185')]
        SunO,

        [Char('\uf12b')]
        Superscript,

        [Char('\uf1cd')]
        Support,

        [Char('\uf0ce')]
        Table,

        [Char('\uf10a')]
        Tablet,

        [Char('\uf0e4')]
        Tachometer,

        [Char('\uf02b')]
        Tag,

        [Char('\uf02c')]
        Tags,

        [Char('\uf0ae')]
        Tasks,

        [Char('\uf1ba')]
        Taxi,

        [Char('\uf1d5')]
        TencentWeibo,

        [Char('\uf120')]
        Terminal,

        [Char('\uf034')]
        TextHeight,

        [Char('\uf035')]
        TextWidth,

        [Char('\uf00a')]
        Th,

        [Char('\uf009')]
        ThLarge,

        [Char('\uf00b')]
        ThList,

        [Char('\uf08d')]
        ThumbTack,

        [Char('\uf165')]
        ThumbsDown,

        [Char('\uf088')]
        ThumbsODown,

        [Char('\uf087')]
        ThumbsOUp,

        [Char('\uf164')]
        ThumbsUp,

        [Char('\uf145')]
        Ticket,

        [Char('\uf00d')]
        Times,

        [Char('\uf057')]
        TimesCircle,

        [Char('\uf05c')]
        TimesCircleO,

        [Char('\uf043')]
        Tint,

        [Char('\uf150')]
        ToggleDown,

        [Char('\uf191')]
        ToggleLeft,

        [Char('\uf204')]
        ToggleOff,

        [Char('\uf205')]
        ToggleOn,

        [Char('\uf152')]
        ToggleRight,

        [Char('\uf151')]
        ToggleUp,

        [Char('\uf238')]
        Train,

        [Char('\uf224')]
        Transgender,

        [Char('\uf225')]
        TransgenderAlt,

        [Char('\uf1f8')]
        Trash,

        [Char('\uf014')]
        TrashO,

        [Char('\uf1bb')]
        Tree,

        [Char('\uf181')]
        Trello,

        [Char('\uf091')]
        Trophy,

        [Char('\uf0d1')]
        Truck,

        [Char('\uf195')]
        Try,

        [Char('\uf1e4')]
        Tty,

        [Char('\uf173')]
        Tumblr,

        [Char('\uf174')]
        TumblrSquare,

        [Char('\uf195')]
        TurkishLira,

        [Char('\uf1e8')]
        Twitch,

        [Char('\uf099')]
        Twitter,

        [Char('\uf081')]
        TwitterSquare,

        [Char('\uf0e9')]
        Umbrella,

        [Char('\uf0cd')]
        Underline,

        [Char('\uf0e2')]
        Undo,

        [Char('\uf19c')]
        University,

        [Char('\uf127')]
        Unlink,

        [Char('\uf09c')]
        Unlock,

        [Char('\uf13e')]
        UnlockAlt,

        [Char('\uf0dc')]
        Unsorted,

        [Char('\uf093')]
        Upload,

        [Char('\uf155')]
        Usd,

        [Char('\uf007')]
        User,

        [Char('\uf0f0')]
        UserMd,

        [Char('\uf234')]
        UserPlus,

        [Char('\uf21b')]
        UserSecret,

        [Char('\uf235')]
        UserTimes,

        [Char('\uf0c0')]
        Users,

        [Char('\uf221')]
        Venus,

        [Char('\uf226')]
        VenusDouble,

        [Char('\uf228')]
        VenusMars,

        [Char('\uf237')]
        Viacoin,

        [Char('\uf03d')]
        VideoCamera,

        [Char('\uf194')]
        VimeoSquare,

        [Char('\uf1ca')]
        Vine,

        [Char('\uf189')]
        Vk,

        [Char('\uf027')]
        VolumeDown,

        [Char('\uf026')]
        VolumeOff,

        [Char('\uf028')]
        VolumeUp,

        [Char('\uf071')]
        Warning,

        [Char('\uf1d7')]
        Wechat,

        [Char('\uf18a')]
        Weibo,

        [Char('\uf1d7')]
        Weixin,

        [Char('\uf232')]
        Whatsapp,

        [Char('\uf193')]
        Wheelchair,

        [Char('\uf1eb')]
        Wifi,

        [Char('\uf17a')]
        Windows,

        [Char('\uf159')]
        Won,

        [Char('\uf19a')]
        Wordpress,

        [Char('\uf0ad')]
        Wrench,

        [Char('\uf168')]
        Xing,

        [Char('\uf169')]
        XingSquare,

        [Char('\uf19e')]
        Yahoo,

        [Char('\uf1e9')]
        Yelp,

        [Char('\uf157')]
        Yen,

        [Char('\uf167')]
        Youtube,

        [Char('\uf16a')]
        YoutubePlay,

        [Char('\uf166')]
        YoutubeSquare,
    }
}
