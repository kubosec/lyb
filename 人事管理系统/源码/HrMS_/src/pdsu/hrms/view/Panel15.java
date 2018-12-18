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
	private JButton btnAdd;
	private JButton btnUpdate;
	private JButton btnDelete;
	private JButton btnClear;
	
	//�������
	String[] colTitle = new String[] {"���ű��","һ������","��������"};
	String[][] colValue = null;
	public Panel15() {
		//����Ϊ�߽粼��
		setLayout(new BorderLayout());
		
		
		initTop();
		initCenter();
		initBottom();
		
	}
	//��ʼ���ϲ����
	public void initTop() {
		pTop = new JPanel();
		//�����ձ��
//		table = new JTable(10,3);
		colValue = DeptDao.getDeptsForTable();
		
//		String[] colTitle = new String[] {"���ű��","һ������","��������"};
//		String[][] colValue = new String[10][3];
//		colValue[0][0]="1";
//		colValue[0][1]="�칫��";
//		colValue[0][2]="�ۺϿ�";
//		colValue[1][0]="2";
//		colValue[1][1]="���´�";
//		colValue[1][2]="���¿�";
		
		
		table = new JTable(colValue,colTitle);
		//���ñ���Ĭ�ϴ�С
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
	lbDeptId = new JLabel("���");
	tfDeptId = new JTextField(10);
	
	lbDept1Name = new JLabel("һ������");
	tfDept1Name = new JTextField(10);
	
	lbDept2Name = new JLabel("��������");
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
		btnNextId = new JButton("��ȡ�±��");
		btnNextId.addActionListener(this);
		btnAdd = new JButton("����");
		btnAdd.addActionListener(this);
		btnUpdate = new JButton("�޸�");
		btnUpdate.addActionListener(this);
		btnDelete = new JButton("ɾ��");
		btnDelete.addActionListener(this);
		btnClear = new JButton("���");
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
			//�ӽ����ȡ����
			String deptId = tfDeptId.getText();
			String dept1Name = tfDept1Name.getText();
			String dept2Name = tfDept2Name.getText();
			
			//������֤
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "�����벿�ű��!");
				return ;
			}
			//�����ݷ�װ��dept������
			Dept dept = new Dept();
			dept.setDeptId(Long.parseLong(deptId));
			dept.setDept1Name(dept1Name);
			dept.setDept2Name(dept2Name);
			
			//��ӵ����ݿ���
			DeptDao.add(dept);
			JOptionPane.showMessageDialog(null, "��ӳɹ���");
			
			//���±������
			updateTable();
		}
		if(e.getSource()==btnUpdate) {
			//�ӽ����ȡ����
			String deptId = tfDeptId.getText();
			String dept1Name = tfDept1Name.getText();
			String dept2Name = tfDept2Name.getText();
			
			//������֤
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "�����벿�ű��!");
				return ;
			}
			//�����ݷ�װ��dept������
			Dept dept = new Dept();
			dept.setDeptId(Long.parseLong(deptId));
			dept.setDept1Name(dept1Name);
			dept.setDept2Name(dept2Name);
			
			//�޸Ĳ��ύ�����ݿ���
			DeptDao.update(dept);
			JOptionPane.showMessageDialog(null, "�޸ĳɹ���");
			
			//���±������
			updateTable();
		}
		if(e.getSource()==btnDelete) {
			//�ӽ����ȡ����
			String deptId = tfDeptId.getText();
			String dept1Name = tfDept1Name.getText();
			String dept2Name = tfDept2Name.getText();
			
			//������֤
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "�����벿�ű��!");
				return ;
			}
			//ɾ�����ݿ��ж�Ӧ�Ĳ�����Ϣ
			DeptDao.delete(Long.parseLong(deptId));
			JOptionPane.showMessageDialog(null, "ɾ���ɹ���");
			
			//���±������
			updateTable();
		}
		if(e.getSource()==btnClear) {
			tfDeptId.setText(null);
			tfDept1Name.setText(null);
			tfDept2Name.setText(null);
		}

	}

}
