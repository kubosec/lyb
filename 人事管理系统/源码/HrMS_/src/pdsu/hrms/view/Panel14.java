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

import pdsu.hrms.dao.PersonDao;

public class Panel14 extends JPanel{
	
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
	public Panel14() {
		//����Ϊ���������
				GridBagLayout gridBag = new GridBagLayout();
				GridBagConstraints cons = null;
				setLayout(gridBag);
				
				//��ӱ���
				JLabel lbTitle = new JLabel("��ѯ��Ա��Ϣ");
				lbTitle.setFont(new Font("����",0,16));
				cons = new GridBagConstraints();
				cons.gridx = 0;
				cons.gridy = 0;
				gridBag.setConstraints(lbTitle, cons);
				add(lbTitle);
				
				//�����������
				initContent();  //��ʼ�������Ա��Ϣ����
				js = new JScrollPane(table);
				js.setPreferredSize(new Dimension(450, 380));//410,380
				cons = new GridBagConstraints();
				cons.gridx = 0;
				cons.gridy = 1;
				gridBag.setConstraints(js, cons);
				add(js);	
	}
	
	public void initContent() {
		//�����ձ��
//		table = new JTable(10,3);
		String[] colTitle = new String[] {"���","����","��������","����","��ַ","����"};
		String[][] colValue = new String[10][6];
//		colValue[0][0]="1";
//		colValue[0][1]="����";
//		colValue[0][2]="1980-03-19";
//		colValue[0][3]="����";
//		colValue[0][4]="����";
//		colValue[0][5]="����-����";
		colValue = PersonDao.getPersonsForTable();
//		System.out.println(colValue[1]);
//		DefaultTableModel tableModel = new DefaultTableModel(colValue,colTitle);
//		table.setModel(tableModel);
		
		table = new JTable(colValue,colTitle);
		//���ñ���Ĭ�ϴ�С
		table.setPreferredScrollableViewportSize(new Dimension(200,200));
		table.setSelectionMode(DefaultListSelectionModel.SINGLE_SELECTION);
	}

}
