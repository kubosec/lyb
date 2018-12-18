package pdsu.hrms.view;


import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;

import pdsu.hrms.dao.DeptDao;
import pdsu.hrms.model.Dept;

public class Panel15 extends JPanel implements ActionListener{
	
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
	
	//表格数据
	String[] colTitle = new String[] {"部门编号","一级部门","二级部门"};
	String[][] colValue = null;
	public Panel15() {
		//设置为边界布局
		setLayout(new BorderLayout());
		
		
		initTop();
		initCenter();
		initBottom();
		
	}
	//初始化上部面板
	public void initTop() {
		pTop = new JPanel();
		//创建空表格
//		table = new JTable(10,3);
		colValue = DeptDao.getDeptsForTable();
		
//		String[] colTitle = new String[] {"部门编号","一级部门","二级部门"};
//		String[][] colValue = new String[10][3];
//		colValue[0][0]="1";
//		colValue[0][1]="办公室";
//		colValue[0][2]="综合科";
//		colValue[1][0]="2";
//		colValue[1][1]="人事处";
//		colValue[1][2]="人事科";
		
		
		table = new JTable(colValue,colTitle);
		//设置表格的默认大小
		table.setPreferredScrollableViewportSize(new Dimension(450, 310));//430,300
		table.setSelectionMode(DefaultListSelectionModel.SINGLE_SELECTION);
		table.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub
				int row = table.getSelectedRow();
				
				tfDeptId.setText(colValue[row][0]);
				tfDept1Name.setText(colValue[row][1]);
				tfDept2Name.setText(colValue[row][2]);
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
		js = new JScrollPane(table);
		js.setPreferredSize(new Dimension(430,300));
		pTop.add(js);
		
		add(pTop,BorderLayout.NORTH);
	}
	public void initCenter() {
	pCenter = new JPanel();
	lbDeptId = new JLabel("编号");
	tfDeptId = new JTextField(10);
	
	lbDept1Name = new JLabel("一级部门");
	tfDept1Name = new JTextField(10);
	
	lbDept2Name = new JLabel("二级部门");
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
		btnNextId = new JButton("获取新编号");
		btnNextId.addActionListener(this);
		btnAdd = new JButton("增加");
		btnAdd.addActionListener(this);
		btnUpdate = new JButton("修改");
		btnUpdate.addActionListener(this);
		btnDelete = new JButton("删除");
		btnDelete.addActionListener(this);
		btnClear = new JButton("清空");
		btnClear.addActionListener(this);
		
		
		
		pBottom.add(btnNextId);
		pBottom.add(btnAdd);
		pBottom.add(btnUpdate);
		pBottom.add(btnDelete);
		pBottom.add(btnClear);
		add(pBottom,BorderLayout.SOUTH);
	}
	
	private void updateTable() {
		colValue = DeptDao.getDeptsForTable();
		DefaultTableModel tableModel = new DefaultTableModel(colValue,colTitle);
		table.setModel(tableModel);
	}
	
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		if(e.getSource() == btnNextId) {
//			System.out.println("123456");
			long nextId = DeptDao.getNextId();
//			System.out.println(nextId);
			tfDeptId.setText(String.valueOf(nextId));
			tfDept1Name.setText(null);
			tfDept2Name.setText(null);
		}
		if(e.getSource()==btnAdd) {
			//从界面获取数据
			String deptId = tfDeptId.getText();
			String dept1Name = tfDept1Name.getText();
			String dept2Name = tfDept2Name.getText();
			
			//数据验证
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "请输入部门编号!");
				return ;
			}
			//把数据封装到dept对象中
			Dept dept = new Dept();
			dept.setDeptId(Long.parseLong(deptId));
			dept.setDept1Name(dept1Name);
			dept.setDept2Name(dept2Name);
			
			//添加到数据库中
			DeptDao.add(dept);
			JOptionPane.showMessageDialog(null, "添加成功！");
			
			//更新表格数据
			updateTable();
		}
		if(e.getSource()==btnUpdate) {
			//从界面获取数据
			String deptId = tfDeptId.getText();
			String dept1Name = tfDept1Name.getText();
			String dept2Name = tfDept2Name.getText();
			
			//数据验证
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "请输入部门编号!");
				return ;
			}
			//把数据封装到dept对象中
			Dept dept = new Dept();
			dept.setDeptId(Long.parseLong(deptId));
			dept.setDept1Name(dept1Name);
			dept.setDept2Name(dept2Name);
			
			//修改并提交到数据库中
			DeptDao.update(dept);
			JOptionPane.showMessageDialog(null, "修改成功！");
			
			//更新表格数据
			updateTable();
		}
		if(e.getSource()==btnDelete) {
			//从界面获取数据
			String deptId = tfDeptId.getText();
			String dept1Name = tfDept1Name.getText();
			String dept2Name = tfDept2Name.getText();
			
			//数据验证
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "请输入部门编号!");
				return ;
			}
			//删除数据库中对应的部门信息
			DeptDao.delete(Long.parseLong(deptId));
			JOptionPane.showMessageDialog(null, "删除成功！");
			
			//更新表格数据
			updateTable();
		}
		if(e.getSource()==btnClear) {
			tfDeptId.setText(null);
			tfDept1Name.setText(null);
			tfDept2Name.setText(null);
		}

	}

}
