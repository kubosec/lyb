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
import javax.swing.table.DefaultTableModel;

import pdsu.hrms.dao.DeptDao;
import pdsu.hrms.dao.PersonDao;

public class Panel13 extends JPanel implements ActionListener{
	
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
	String[][] colValue;
	String[] colTitle = new String[] {"编号","姓名","出生年月","民族","地址","部门"};
	public Panel13() {
		//设置为边界布局
		setLayout(new BorderLayout());
		
		
		
		
		
		initTop();
		initCenter();
		initBottom();
		
	}
	//初始化上部面板
	public void initTop() {
		pTop = new JPanel();
		//设置为网格包布局
		GridBagLayout gridBag = new GridBagLayout();
		GridBagConstraints cons = null;
		pTop.setLayout(gridBag);
		
		//添加标题
		JLabel lbTitle = new JLabel("人员信息删除");
		lbTitle.setFont(new Font("宋体",0,16));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 0;
		gridBag.setConstraints(lbTitle, cons);
		pTop.add(lbTitle);
		
		//添加内容区域
				initContent();  //初始化添加人员信息区域
				js = new JScrollPane(table);
				js.setPreferredSize(new Dimension(450, 310));//350,310
				cons = new GridBagConstraints();
				cons.gridx = 0;
				cons.gridy = 1;
				gridBag.setConstraints(js, cons);
				pTop.add(js);
		
		add(pTop,BorderLayout.NORTH);
	}
	
	public void initContent() {
		//创建空表格
//		table = new JTable(10,3);
		
		colValue = new String[10][6];
		colValue = PersonDao.getPersonsForTable();
//		colValue[0][0]="1";
//		colValue[0][1]="张三";
//		colValue[0][2]="1980-03-19";
//		colValue[0][3]="汉族";
//		colValue[0][4]="北京";
//		colValue[0][5]="教务处-主任";
		
		
		table = new JTable(colValue,colTitle);
		//设置表格的默认大小
		table.setPreferredScrollableViewportSize(new Dimension(200,200));
		table.setSelectionMode(DefaultListSelectionModel.SINGLE_SELECTION);
		table.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub
				int row = table.getSelectedRow();
				
				tfDeptId.setText(colValue[row][0]);
				tfDept1Name.setText(colValue[row][1]);
				tfDept2Name.setText(colValue[row][5]);
			}
			
			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
		});
	}
	public void initCenter() {
	pCenter = new JPanel();
	lbDeptId = new JLabel("编号");
	tfDeptId = new JTextField(10);
	
	lbDept1Name = new JLabel("姓名");
	tfDept1Name = new JTextField(10);
	
	lbDept2Name = new JLabel("部门");
	tfDept2Name = new JTextField(10);
	
	
	pCenter.add(lbDeptId);
	pCenter.add(tfDeptId);
	
	pCenter.add(lbDept1Name);
	pCenter.add(tfDept1Name);
	
	
	pCenter.add(lbDept2Name);
	pCenter.add(tfDept2Name);
	add(pCenter,BorderLayout.CENTER);
	}
	
	
	public void initBottom() {
		pBottom =  new JPanel();
		btnDelete = new JButton("删除");
		btnDelete.addActionListener(this);
		
		pBottom.add(btnDelete);
		add(pBottom,BorderLayout.SOUTH);
	}
	private void updateTable() {
		colValue = PersonDao.getPersonsForTable();
		DefaultTableModel tableModel = new DefaultTableModel(colValue,colTitle);
		table.setModel(tableModel);
	}
	
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		if(e.getSource()==btnDelete) {
			//从界面获取数据
			String deptId = tfDeptId.getText();
//			String dept1Name = tfDept1Name.getText();
//			String dept2Name = tfDept2Name.getText();
//			System.out.println(deptId);
			//数据验证
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "请输入人员编号!");
				return ;
			}
			//删除数据库中对应的部门信息
			PersonDao.delete(Long.parseLong(deptId));
			JOptionPane.showMessageDialog(null, "删除成功！");
			
			//更新表格数据
			updateTable();
		}

	}

}
