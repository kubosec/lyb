package pdsu.hrms.model;

public class History {
private long histId;
private String histType;
private String oldInfo;
private String newInfo;
private String chgDate;
private long chgNum;
private long personId;
private String oldSalary;
private String newSalary;
 
 
 public String getOldSalary() {
	return oldSalary;
}


public void setOldSalary(String oldSalary) {
	this.oldSalary = oldSalary;
}


public String getNewSalary() {
	return newSalary;
}


public void setNewSalary(String newSalary) {
	this.newSalary = newSalary;
}


//扩展属性
private String name;//员工姓名

public long getHistId() {
	return histId;
}


public void setHistId(long histId) {
	this.histId = histId;
}


public String getHistType() {
	return histType;
}


public void setHistType(String histType) {
	this.histType = histType;
}


public String getOldInfo() {
	return oldInfo;
}


public void setOldInfo(String oldInfo) {
	this.oldInfo = oldInfo;
}


public String getNewInfo() {
	return newInfo;
}


public void setNewInfo(String newInfo) {
	this.newInfo = newInfo;
}


public String getChgDate() {
	return chgDate;
}


public void setChgDate(String chgDate) {
	this.chgDate = chgDate;
}


public long getChgNum() {
	return chgNum;
}


public void setChgNum(long chgNum) {
	this.chgNum = chgNum;
}


public long getPersonId() {
	return personId;
}


public void setPersonId(long personId) {
	this.personId = personId;
}


public String getName() {
	return name;
}


public void setName(String name) {
	this.name = name;
}



}
