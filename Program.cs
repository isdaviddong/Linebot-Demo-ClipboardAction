using isRock.LineBot;

string ChannelAccessToken = "👉ChannelAccessToken";
string AdminUserId = "👉AdminUserId";


var bot = new isRock.LineBot.Bot(ChannelAccessToken);
var act = new List<TemplateActionBase>();
act.Add(new ClipboardAction() { label = "按這裡", clipboardText = "abc" });
var TmpMsg = new ButtonsTemplate() { text = "測試複製到剪貼簿", title = "測試", actions = act };
bot.PushMessage(AdminUserId, TmpMsg);