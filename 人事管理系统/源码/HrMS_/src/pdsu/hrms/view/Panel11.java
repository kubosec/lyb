package pdsu.hrms.view;

import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextField;

import pdsu.hrms.dao.DeptDao;
import pdsu.hrms.dao.PersonDao;
import pdsu.hrms.model.Dept;
import pdsu.hrms.model.Person;

public class Panel11 extends JPanel implements ActionListener{
	//JPanel pTitle;  //标题区域面板
	JPanel pContent;  //添加人员信息内容区域面板
	JScrollPane js;   //添加人员信息所在的滚动面板
	
	JTextField tfPersonId;  //人员编号
	JTextField tfName;  //姓名
	JTextField tfSex;   //性别
	JTextField tfBirth;  //出生日期
	JTextField tfNat;    //民族
	JTextField tfAddress; //地址
	JTextField tfOther;   //其他说明
	
	JComboBox<String> comboDept;  //部门信息
	
	JButton btnAdd;  //增加
	JButton btnClear; //清空
	
	public Panel11() {
		//设置为网格包布局
		GridBagLayout gridBag = new GridBagLayout();
		GridBagConstraints cons = null;
		setLayout(gridBag);
		
		//添加标题
		JLabel lbTitle = new JLabel("添加人员信息");
		lbTitle.setFont(new Font("宋体",0,16));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 0;
		gridBag.setConstraints(lbTitle, cons);
		add(lbTitle);
		
		//添加内容区域
		initContent();  //初始化添加人员信息区域
		js = new JScrollPane(pContent);
		js.setPreferredSize(new Dimension(450, 380));//410
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 1;
		gridBag.setConstraints(js, cons);
		add(js);
	}
	public void initContent() {
		//创建内容面板并设置布局方式
		pContent = new JPanel();
		GridBagLayout layout = new GridBagLayout();
		pContent.setLayout(layout);
		
		GridBagConstraints cons = null;
		
		//添加第1行组件（人员编号标签、人员编号文本框、人员姓名标签、人员姓名文本框）
		//人员编号标签
		JLabel lbPersonId = new JLabel("人员编号");
		//lbPersonId.setFont(new Font("宋体",0,12));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 0;
		cons.insets = new Insets(10,10,10,1);//上左下右间距
		layout.setConstraints(lbPersonId, cons);
		pContent.add(lbPersonId);
		//人员编号文本框
		tfPersonId = new JTextField(15);
		long pid = PersonDao.getNextId();
		tfPersonId.setText(String.valueOf(pid));
		tfPersonId.setEditable(false);
		
		
		
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 0;
		cons.insets = new Insets(10,1,10,15);
		layout.setConstraints(tfPersonId, cons);
		pContent.add(tfPersonId);
		//人员姓名标签
		JLabel lbName = new JLabel("人员姓名");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 0;
		cons.insets = new Insets(10,15,10,1);
		layout.setConstraints(lbName, cons);
		pContent.add(lbName);
		//人员姓名文本框
		tfName = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 3;
		cons.gridy = 0;
		cons.insets = new Insets(10,1,10,10);
		layout.setConstraints(tfName, cons);
		pContent.add(tfName);
		
		//添加第2行组件（性别标签、性别文本框、出生年月标签、出生年月文本框）
		//性别标签
		JLabel lbSex = new JLabel("性别");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 1;
		cons.insets = new Insets(10,10,10,1);
		layout.setConstraints(lbSex, cons);
		pContent.add(lbSex);
		//性别文本框
		tfSex = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 1;
		cons.insets = new Insets(10,1,10,15);
//		cons.gridwidth  = 3;
//		cons.anchor = GridBagConstraints.WEST;
		layout.setConstraints(tfSex, cons);
		pContent.add(tfSex);
		//出生年月标签
		JLabel lbBirth = new JLabel("出生年月");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 1;
		cons.insets = new Insets(10,15,10,1);
		layout.setConstraints(lbBirth, cons);
		pContent.add(lbBirth);
		//出生年月文本框
		tfBirth = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 3;
		cons.gridy = 1;
		cons.insets = new Insets(10,1,10,10);
		layout.setConstraints(tfBirth, cons);
		pContent.add(tfBirth);
		
		//添加第3行组件（民族标签、民族文本框、地址标签、地址文本框）
		//民族标签
		JLabel lbNat = new JLabel("民族");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 2;
		cons.insets = new Insets(10,10,10,1);
		layout.setConstraints(lbNat, cons);
		pContent.add(lbNat);
		//民族文本框
		tfNat = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 2;
		cons.insets = new Insets(10,1,10,15);
		layout.setConstraints(tfNat, cons);
		pContent.add(tfNat);
		//地址标签
		JLabel lbAddress = new JLabel("地址");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 2;
		cons.insets = new Insets(10,15,10,1);
		layout.setConstraints(lbAddress, cons);
		pContent.add(lbAddress);
		//地址文本框
		tfAddress = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 3;
		cons.gridy = 2;
		cons.insets = new Insets(10,1,10,10);
		layout.setConstraints(tfAddress, cons);
		pContent.add(tfAddress);
		
		//添加第4行组件（部门标签、部门下拉列表、其他标签、其他文本框）
		//部门标签
		JLabel lbDept = new JLabel("部门");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 3;
		cons.insets = new Insets(10,10,10,1);
		layout.setConstraints(lbDept, cons);
		pContent.add(lbDept);
		//部门下拉列表
		comboDept = new JComboBox<String>();
		
		//为部门下拉列表添加数据
		String[] depts = DeptDao.getDeptsForSelect();
		for(int i=0;i<depts.length;i++) {
			comboDept.addItem(depts[i]);
		}
		
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 3;
		cons.insets = new Insets(10,1,10,15);
		layout.setConstraints(comboDept, cons);
		pContent.add(comboDept);
		//其他标签
		JLabel lbOther = new JLabel("其他");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 3;
		cons.insets = new Insets(10,15,10,1);
		layout.setConstraints(lbOther, cons);
		pContent.add(lbOther);
		//其他文本框
		tfOther = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 3;
		cons.gridy = 3;
		cons.insets = new Insets(10,1,10,10);
		layout.setConstraints(tfOther, cons);
		pContent.add(tfOther);
		
		//添加第5行组件（增加按钮、清空按钮）
		//增加
		btnAdd = new JButton("增加");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 4;
		cons.gridwidth = 2;
		cons.insets = new Insets(10,10,10,10);
		layout.setConstraints(btnAdd, cons);
		pContent.add(btnAdd);
		//清空
		btnClear = new JButton("清空");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 4;
		cons.gridwidth = 2;
		cons.insets = new Insets(10,10,10,10);
		layout.setConstraints(btnClear, cons);
		pContent.add(btnClear);
		
		btnAdd.addActionListener(this);
		btnClear.addActionListener(this);
	}
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		if(e.getSource()==btnAdd) {
			//从界面获取数据
			String personId = tfPersonId.getText();
			String personName = tfName.getText();
			String personSex = tfSex.getText();
			String personBirth = tfBirth.getText();
			String personNat = tfNat.getText();
			String personAddress = tfAddress.getText();
			String personOther = tfOther.getText();
			
			String dept = comboDept.getSelectedItem().toString();
			
			//提取部门编号
			String[] deptParts = dept.split("-");
			String deptId = deptParts[0];
//			String deptId = tfDeptId.getText();
//			String dept1Name = tfDept1Name.getText();
//			String dept2Name = tfDept2Name.getText();
			
			//数据验证
//			if(personId==null||personId.equals("")) {
//				JOptionPane.showMessageDialog(null, "请输入部门编号!");
//				return ;
//			}
			//把数据封装到dept对象中
			Person person = new Person();
//			Dept dept = new Dept();
			person.setPersonId(Long.parseLong(personId));
			person.setName(personName);
			person.setSex(personSex);
			person.setBirth(personBirth);
			person.setNat(personNat);
			person.setAddress(personAddress);
			person.setDeptId(Long.parseLong(deptId));
//			person.setSalary(salary);
			person.setOther(personOther);
			person.setAssess("未考核");
//			person.setDept1Name(dept1Name);
//			person.setDept2Name(dept2Name);
			
			//添加到数据库中
			PersonDao.add(person);
			JOptionPane.showMessageDialog(null, "添加成功！");
			
			//更新表格数据
//			updateTable();
		}
		if(e.getSource()==btnClear) {
			tfName.setText(null);  //姓名
			tfSex.setText(null);   //性别
			tfBirth.setText(null);  //出生日期
			tfNat.setText(null);    //民族
			tfAddress.setText(null); //地址
			tfOther.setText(null);   //其他说明
		}
	}
}
