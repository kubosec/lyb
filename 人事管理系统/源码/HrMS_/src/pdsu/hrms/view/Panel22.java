package pdsu.hrms.view;


import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.*;

import pdsu.hrms.dao.HistoryDao;
import pdsu.hrms.dao.PersonDao;

public class Panel22 extends JPanel{
	
	//定义各种属性
	//定义面板
	private JPanel pTop;
	private JPanel pCenter;
	private JPanel pBottom;
	
	
	private JTable table;
	private JScrollPane js;
	
	//定义中部所需组件
	private JLabel lbDeptId;
	private JLabel lbDept1Name;
	private JLabel lbDept2Name;
	
	private  JTextField tfDeptId;
	
	
	private JTextField tfDept2Name;
	private JTextField tfDept1Name;
	
	//定义底部所需件
	private JButton btnNextId;
	private JButton btnAdd;
	private JButton btnUpdate;
	private JButton btnDelete;
	private JButton btnClear;
	public Panel22() {
		//设置为网格包布局
				GridBagLayout gridBag = new GridBagLayout();
				GridBagConstraints cons = null;
				setLayout(gridBag);
				
				//添加标题
				JLabel lbTitle = new JLabel("调动历史查询");
				lbTitle.setFont(new Font("宋体",0,16));
				cons = new GridBagConstraints();
				cons.gridx = 0;
				cons.gridy = 0;
				gridBag.setConstraints(lbTitle, cons);
				add(lbTitle);
				
				//添加内容区域
				initContent();  //初始化添加人员信息区域
				js = new JScrollPane(table);
				js.setPreferredSize(new Dimension(450, 380));//410,380
				cons = new GridBagConstraints();
				cons.gridx = 0;
				cons.gridy = 1;
				gridBag.setConstraints(js, cons);
				add(js);
		
	}
	
	public void initContent() {
		//创建空表格
//		table = new JTable(10,3);
		String[] colTitle = new String[] {"流水号","人员姓名","原部门","新部门","变更次数","变更日期"};
		String[][] colValue = new String[10][6];
//		colValue[0][0]="5";
//		colValue[0][1]="张三";
//		colValue[0][2]="办公室-主任";
//		colValue[0][3]="人事部-主任";
//		colValue[0][4]="1";
//		colValue[0][5]="2010-10-24";
		colValue = HistoryDao.getHistoryPersonForTable();
		
		table = new JTable(colValue,colTitle);
		//设置表格的默认大小
		table.setPreferredScrollableViewportSize(new Dimension(200,200));
		table.setSelectionMode(DefaultListSelectionModel.SINGLE_SELECTION);
	}

}
