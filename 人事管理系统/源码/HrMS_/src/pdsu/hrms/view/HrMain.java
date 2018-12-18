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
//��������
public class HrMain extends JFrame implements TreeSelectionListener{
	//����ָ����
	public static JSplitPane splitPane;
	
	//���˵�
	private JTree tree;
	private DefaultMutableTreeNode root;//���ĸ��ڵ�
	
	//���延ӭ���
	JPanel pWelcome;
	
	public HrMain() {
		// TODO Auto-generated constructor stub
	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);//�رճ���ʱ�Ƴ�
	setSize(700,450);
	setLocationRelativeTo(null);//�����Ļ����
	setResizable(false);//��С���ɱ�
	setTitle("���¹���ϵͳ");//����
	//���ô���ͼ��
	//(1)�ҵ�ͼƬλ��
	URL url = getClass().getClassLoader().getResource("tmp.png");
	//��2������ͼƬ���ڴ�
	Image image = Toolkit.getDefaultToolkit().getImage(url);
	//��3����ͼƬ��Ϊ����ͼ��
	setIconImage(image);
	
	
	init();//���ó�ʼ������
	
	setVisible(true);//���ô��ڿɼ�
	}
	
	
	public void init() {
		//��ʼ���ָ����
		splitPane = new JSplitPane(splitPane.HORIZONTAL_SPLIT);
		splitPane.setDividerLocation(150);//�ָ��λ�ã����150���أ�
		splitPane.setContinuousLayout(true);//�ָ��������䶯
		splitPane.setDividerSize(2);//���÷ָ������
		//��Ӳ����õ����
		splitPane.setLeftComponent(new JButton("left"));
		splitPane.setRightComponent(new JButton("right"));
		
		//��ʼ�����˵�DefaultMutableTreeNode
		root = new DefaultMutableTreeNode("���¹���ϵͳ");
		DefaultMutableTreeNode node1 = new DefaultMutableTreeNode("������Ϣ����");
		DefaultMutableTreeNode node2 = new DefaultMutableTreeNode("��Ա��������");
		DefaultMutableTreeNode node3 = new DefaultMutableTreeNode("��Ա���˹���");
		DefaultMutableTreeNode node4 = new DefaultMutableTreeNode("���ʹ���");
		
		DefaultMutableTreeNode leafNode = null;
		//��ӻ�����Ϣ������Ӳ˵�
		node1.add(new DefaultMutableTreeNode("�����Ա��Ϣ"));
		node1.add(new DefaultMutableTreeNode("�޸���Ա��Ϣ"));
		node1.add(new DefaultMutableTreeNode("ɾ����Ա��Ϣ"));
		node1.add(new DefaultMutableTreeNode("��ѯ��Ա��Ϣ"));
		node1.add(new DefaultMutableTreeNode("���Ź���"));
		
		node2.add(new DefaultMutableTreeNode("��Ա����"));
		node2.add(new DefaultMutableTreeNode("������ʷ��ѯ"));
		
		node3.add(new DefaultMutableTreeNode("��Ա����"));
		node3.add(new DefaultMutableTreeNode("������ʷ��ѯ"));
		
		node4.add(new DefaultMutableTreeNode("���ʷ������"));
		node4.add(new DefaultMutableTreeNode("������ʷ��ѯ"));
		
		root.add(node1);
		root.add(node2);
		root.add(node3);
		root.add(node4);
		
		//�����˵���ӵ�������
		tree = new JTree(root);
		tree.addTreeSelectionListener(this);
		//splitPane.setLeftComponent(new JScrollPane(tree));
		//�������ͨ��壬����ӹ������
		JPanel pLeft = new JPanel();
		JScrollPane js = new JScrollPane(tree);
		js.setPreferredSize(new Dimension(140,410));
		pLeft.add(js);
		splitPane.setLeftComponent(pLeft);
		
		
		//��ӭ
		pWelcome = new JPanel();
		JLabel lbWelcome = new JLabel("��ӭ");
		lbWelcome.setFont(new Font("����",Font.PLAIN,16));
		pWelcome.add(lbWelcome);
		splitPane.setRightComponent(pWelcome);;
		
		
		//�ָ������뵽������
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
	//�����˵������¼�����
	@Override
	public void valueChanged(TreeSelectionEvent e) {
		//System.out.println(e.getPath());
		String menuStr = e.getPath().getLastPathComponent().toString();
		System.out.println(menuStr);
		switch(menuStr) {
			case "���¹���ϵͳ":
				//System.out.println("�Ҳ�Ӧ���������Ա����");
				//splitPane.setRightComponent(pWelcome);
				break;
			
			case "������Ϣ����":;
			case "��Ա��������":;
			case "��Ա���˹���":;
			case "���ʹ���":
				//�ҵ���ǰ���·��
				TreePath path = e.getPath();
				//���·����չ��״̬�����Ϊ�۵�
				if(tree.isExpanded(path)) {
					tree.collapsePath(path);
				}else {
					tree.expandPath(path);
				}
				break;
			case "�����Ա��Ϣ":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel11());
				break;
			case "�޸���Ա��Ϣ":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel12());
				break;
			case "ɾ����Ա��Ϣ":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel13());
				break;
			case "��ѯ��Ա��Ϣ":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel14());
				break;
			case "���Ź���":
				System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel15());
				break;
			case "��Ա����":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel21());
				break;
			case "������ʷ��ѯ":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel22());
				break;
			case "��Ա����":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel31());
				break;
			case "������ʷ��ѯ":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel32());
				break;
			case "���ʷ������":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel41());
				break;
			case "������ʷ��ѯ":
				//System.out.println("�Ҳ�Ӧ�����޸���Ա����");
				splitPane.setRightComponent(new Panel42());
				break;
		}
	}
	
}
