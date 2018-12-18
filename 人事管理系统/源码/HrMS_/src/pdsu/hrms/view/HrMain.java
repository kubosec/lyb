package pdsu.hrms.view;

import java.awt.Dimension;
import java.awt.Font;
import java.awt.Image;
import java.awt.Toolkit;
import java.net.URL;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JSplitPane;
import javax.swing.JTree;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;
import javax.swing.event.TreeSelectionEvent;
import javax.swing.event.TreeSelectionListener;
import javax.swing.plaf.multi.MultiLookAndFeel;
import javax.swing.tree.DefaultMutableTreeNode;
import javax.swing.tree.TreePath;
//主界面类
public class HrMain extends JFrame implements TreeSelectionListener{
	//定义分割面板
	public static JSplitPane splitPane;
	
	//树菜单
	private JTree tree;
	private DefaultMutableTreeNode root;//树的根节点
	
	//定义欢迎面板
	JPanel pWelcome;
	
	public HrMain() {
		// TODO Auto-generated constructor stub
	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);//关闭程序时推出
	setSize(700,450);
	setLocationRelativeTo(null);//相对屏幕居中
	setResizable(false);//大小不可变
	setTitle("人事管理系统");//标题
	//设置窗口图标
	//(1)找到图片位置
	URL url = getClass().getClassLoader().getResource("tmp.png");
	//（2）加载图片到内存
	Image image = Toolkit.getDefaultToolkit().getImage(url);
	//（3）把图片设为窗口图标
	setIconImage(image);
	
	
	init();//调用初始化方法
	
	setVisible(true);//设置窗口可见
	}
	
	
	public void init() {
		//初始化分割面板
		splitPane = new JSplitPane(splitPane.HORIZONTAL_SPLIT);
		splitPane.setDividerLocation(150);//分割调位置（左侧150像素）
		splitPane.setContinuousLayout(true);//分割条连续变动
		splitPane.setDividerSize(2);//设置分割面板宽度
		//添加测试用的组件
		splitPane.setLeftComponent(new JButton("left"));
		splitPane.setRightComponent(new JButton("right"));
		
		//初始化树菜单DefaultMutableTreeNode
		root = new DefaultMutableTreeNode("人事管理系统");
		DefaultMutableTreeNode node1 = new DefaultMutableTreeNode("基本信息管理");
		DefaultMutableTreeNode node2 = new DefaultMutableTreeNode("人员调动管理");
		DefaultMutableTreeNode node3 = new DefaultMutableTreeNode("人员考核管理");
		DefaultMutableTreeNode node4 = new DefaultMutableTreeNode("劳资管理");
		
		DefaultMutableTreeNode leafNode = null;
		//添加基本信息管理的子菜单
		node1.add(new DefaultMutableTreeNode("添加人员信息"));
		node1.add(new DefaultMutableTreeNode("修改人员信息"));
		node1.add(new DefaultMutableTreeNode("删除人员信息"));
		node1.add(new DefaultMutableTreeNode("查询人员信息"));
		node1.add(new DefaultMutableTreeNode("部门管理"));
		
		node2.add(new DefaultMutableTreeNode("人员调动"));
		node2.add(new DefaultMutableTreeNode("调动历史查询"));
		
		node3.add(new DefaultMutableTreeNode("人员考核"));
		node3.add(new DefaultMutableTreeNode("考核历史查询"));
		
		node4.add(new DefaultMutableTreeNode("劳资分配管理"));
		node4.add(new DefaultMutableTreeNode("劳资历史查询"));
		
		root.add(node1);
		root.add(node2);
		root.add(node3);
		root.add(node4);
		
		//把树菜单添加到窗口中
		tree = new JTree(root);
		tree.addTreeSelectionListener(this);
		//splitPane.setLeftComponent(new JScrollPane(tree));
		//先添加普通面板，再添加滚动面板
		JPanel pLeft = new JPanel();
		JScrollPane js = new JScrollPane(tree);
		js.setPreferredSize(new Dimension(140,410));
		pLeft.add(js);
		splitPane.setLeftComponent(pLeft);
		
		
		//欢迎
		pWelcome = new JPanel();
		JLabel lbWelcome = new JLabel("欢迎");
		lbWelcome.setFont(new Font("宋体",Font.PLAIN,16));
		pWelcome.add(lbWelcome);
		splitPane.setRightComponent(pWelcome);;
		
		
		//分割面板加入到界面中
		add(splitPane);
		
		
		
	}
	
	public static void main(String[] args) {
		
			try {
				UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		
		new HrMain();
	}
	//对树菜单进行事件处理
	@Override
	public void valueChanged(TreeSelectionEvent e) {
		//System.out.println(e.getPath());
		String menuStr = e.getPath().getLastPathComponent().toString();
		System.out.println(menuStr);
		switch(menuStr) {
			case "人事管理系统":
				//System.out.println("右侧应出现添加人员界面");
				//splitPane.setRightComponent(pWelcome);
				break;
			
			case "基本信息管理":;
			case "人员调动管理":;
			case "人员考核管理":;
			case "劳资管理":
				//找到当前项的路径
				TreePath path = e.getPath();
				//如果路径是展开状态，则改为折叠
				if(tree.isExpanded(path)) {
					tree.collapsePath(path);
				}else {
					tree.expandPath(path);
				}
				break;
			case "添加人员信息":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel11());
				break;
			case "修改人员信息":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel12());
				break;
			case "删除人员信息":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel13());
				break;
			case "查询人员信息":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel14());
				break;
			case "部门管理":
				System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel15());
				break;
			case "人员调动":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel21());
				break;
			case "调动历史查询":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel22());
				break;
			case "人员考核":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel31());
				break;
			case "考核历史查询":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel32());
				break;
			case "劳资分配管理":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel41());
				break;
			case "劳资历史查询":
				//System.out.println("右侧应出现修改人员界面");
				splitPane.setRightComponent(new Panel42());
				break;
		}
	}
	
}
