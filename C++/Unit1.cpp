//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
String path;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
	// Pre-disable the apply button, because no data
btnApply->Enabled = false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnFileClick(TObject *Sender)
{
//Open a text file with data
this->OpenDialog1->Filter = "txt files (.txt)|*.txt|";
if (!this->OpenDialog1->Execute()) return;
TStringList *list = new TStringList;
//Upload data to the collection
path = this->OpenDialog1->FileName;
list->LoadFromFile(this->OpenDialog1->FileName);
this->ListView1->Clear();

//Deserialization and filling data to lisrview
for(int t=0; t<list->Count; t++)
	{
	
	this->ListView1->Items->Add();
	//Id
	int seporator = list->Strings[t].Pos(",");
	String id = list->Strings[t].SubString(0,seporator-1);
	this->ListView1->Items->Item[t]->Caption=id;
	list->Strings[t] = list->Strings[t].SubString(seporator+1, list->Strings[t].Length());
	
	//First Name
	seporator = list->Strings[t].Pos(",");
	id = list->Strings[t].SubString(0,seporator-1);
	this->ListView1->Items->Item[t]->SubItems->Add(id);
	list->Strings[t] = list->Strings[t].SubString(seporator+1, list->Strings[t].Length());

	//Second Name
	this->ListView1->Items->Item[t]->SubItems->Add(list->Strings[t]);

	if(t==0)
		{
			//Filling the EditText fields
		txFirst->Text = this->ListView1->Items->Item[0]->SubItems->Strings[0];
		txSecond->Text = this->ListView1->Items->Item[0]->SubItems->Strings[1];
		}
	}
	
	//Enable the button to apply for editing
	btnApply->Enabled = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnApplyClick(TObject *Sender)
{
//Saving Editing
if(this->ListView1->Items->Count == 0) return;

//From the edit fields in listview
this->ListView1->Items->Item[0]->SubItems->Strings[0] = txFirst->Text;
this->ListView1->Items->Item[0]->SubItems->Strings[1] = txSecond->Text;


TStringList *list = new TStringList;
//Serialize listview in a collection
for(int i=0; i<this->ListView1->Items->Count; i++)
	{
	list->Add(this->ListView1->Items->Item[i]->Caption+","+
				this->ListView1->Items->Item[i]->SubItems->Strings[0]+","+
				this->ListView1->Items->Item[i]->SubItems->Strings[1]
				);

	}
	//Saving the result to a file
	list->SaveToFile(path);
}
//---------------------------------------------------------------------------
