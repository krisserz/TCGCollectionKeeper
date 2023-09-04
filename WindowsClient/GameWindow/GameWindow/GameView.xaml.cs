using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameWindow;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class GameView : Window
{
    private readonly Window _parent;

    public GameView(Window parentSelector)
    {
        _parent = parentSelector;
        InitializeComponent();
    }

    protected override void OnClosed(EventArgs e)
    {
        _parent.Close();

        base.OnClosed(e);
    }
}