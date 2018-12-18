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
import pdsu.hrms.dao.HistoryDao;
import pdsu.hrms.dao.KaoHistoryDao;
import pdsu.hrms.dao.LaoHistoryDao;
import pdsu.hrms.dao.PersonDao;
import pdsu.hrms.model.Dept;
import pdsu.hrms.model.History;
import pdsu.hrms.model.Person;

public class Panel41 extends JPanel implements ActionListener{
	
	//�����������
	//�������
	private JPanel pTop;
	private JPanel pCenter;
	private JPanel pBottom;
	
	
	private JTable table;
	private JScrollPane js;
	
	//�����в��������
	private JLabel lbDeptId;
	private JLabel lbDept1Name;
	private JLabel lbDept2Name;
	
	private  JTextField tfDeptId;
	
	
	private JTextField tfDept2Name;
	private JTextField tfDept1Name;
	
	//����ײ������
	private JButton btnNextId;
	private JButton btnNextId1;
	private JButton btnAdd;
	private JButton btnUpdate;
	private JButton btnDelete;
	private JButton btnClear;
	public static String newSalary;
	Long id = null;
	Long deptinfo = null;
	
	String[] colTitle = new String[] {"����","����","�Ա�","����","н��","������Ϣ"};
	String[][] colValue;
	public Panel41() {
		//����Ϊ�߽粼��
		setLayout(new BorderLayout());
		
		
		
		
		
		initTop();
		initCenter();
		initBottom();
		
	}
	//��ʼ���ϲ����
	public void initTop() {
		pTop = new JPanel();
		//����Ϊ���������
		GridBagLayout gridBag = new GridBagLayout();
		GridBagConstraints cons = null;
		pTop.setLayout(gridBag);
		
		//��ӱ���
		JLabel lbTitle = new JLabel("���ʷ���");
		lbTitle.setFont(new Font("����",0,16));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 0;
		gridBag.setConstraints(lbTitle, cons);
		pTop.add(lbTitle);
		
		//�����������
				initContent();  //��ʼ�������Ա��Ϣ����
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
		//�����ձ��
//		table = new JTable(10,3);
		
		colValue = new String[10][6];
//		colValue[0][0]="1";
//		colValue[0][1]="����";
//		colValue[0][2]="��";
//		colValue[0][3]="����-����";
//		colValue[0][4]="6000";
//		colValue[0][5]="����";
		colValue = HistoryDao.gethistoryForTable();
		
		table = new JTable(colValue,colTitle);
		//���ñ���Ĭ�ϴ�С
		table.setPreferredScrollableViewportSize(new Dimension(200,200));
		table.setSelectionMode(DefaultListSelectionModel.SINGLE_SELECTION);
		table.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub
				int row = table.getSelectedRow();
				btnNextId.setEnabled(true);
				tfDeptId.setText(colValue[row][1]);
				id = Long.parseLong(colValue[row][0]);
				tfDept1Name.setText(colValue[row][4]);
				//tfDept2Name.setText(colValue[row][5]);
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
	lbDeptId = new JLabel("����");
	tfDeptId = new JTextField(10);
	
	lbDept1Name = new JLabel("����ǰ�Ĺ���");
	tfDept1Name = new JTextField(10);
	
	lbDept2Name = new JLabel("������Ĺ���");
	//tfDept2Name = new JTextField(10);
	tfDept2Name = new JTextField(10);
	
	//Ϊ���������б��������
//			String[] depts = DeptDao.getDeptsForSelect();
//			for(int i=0;i<depts.length;i++) {
//				tfDept2Name.addItem(depts[i]);
//			}
//	
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
		btnNextId = new JButton("ȷ��");
		btnNextId.setEnabled(false);
		btnNextId.addActionListener(this);
		btnNextId1 = new JButton("���");
		btnNextId1.addActionListener(this);
		
		pBottom.add(btnNextId);
		pBottom.add(btnNextId1);
		add(pBottom,BorderLayout.SOUTH);
	}
	private void updateTable() {
		colValue = HistoryDao.gethistoryForTable();
		DefaultTableModel tableModel = new DefaultTableModel(colValue,colTitle);
		table.setModel(tableModel);
	}
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		if(e.getSource()==btnNextId) {
//			tfDeptId.setText("3");
//			tfDept1Name.setText(null);
			//tfDept2Name.setText(null);
			
			//�ӽ����ȡ����
			String deptId = tfDeptId.getText();
			String dept1Name = tfDept1Name.getText();
			
//			String itemSize = (String)tfDept2Name.getSelectedItem();
//			//��ȡ���ű��
//			String[] deptParts = itemSize.split("-");
//			Dept dept = new Dept();
//			Long tmp_id = Long.parseLong(deptParts[0]);
			
//			String dept2Name = tfDept2Name.getText();
			
			//������֤
//			if(deptId==null||deptId.equals("")) {
//				JOptionPane.showMessageDialog(null, "�����벿�ű��!");
//				return ;
//			}
			//�����ݷ�װ��dept������
			newSalary = tfDept2Name.getText();
			Person person = new Person();
//			System.out.println(id);
//			System.out.println(tmp_id);
			person.setPersonId(id);
			person.setSalary(tfDept2Name.getText());
//			person.setDeptId(tmp_id);
//			Dept dept = new Dept();
//			dept.setDeptId(Long.parseLong(deptId));
//			dept.setDept1Name(dept1Name);
//			dept.setDept2Name(dept2Name);
			
			//�޸Ĳ��ύ�����ݿ���
			LaoHistoryDao.update(person);
//			HistoryDao.update(person);
//			DeptDao.update(dept);
			
			Person person1 = new Person();
//			person1.setDeptId(deptinfo);
//			person1.setTmp_id(tmp_id);
			person1.setPersonId(id);
			History history = new History();
			history.setOldInfo(tfDept1Name.getText());
			history.setNewInfo(tfDept2Name.getText());
			LaoHistoryDao.addHistroy(person1, history);
			
			JOptionPane.showMessageDialog(null, "�޸ĳɹ���");
			
			//���±������
			updateTable();
		}
		if(e.getSource()==btnNextId1) {
			tfDeptId.setText(null);
			tfDept1Name.setText(null);
			btnNextId.setEnabled(false);
		}

	}

}
