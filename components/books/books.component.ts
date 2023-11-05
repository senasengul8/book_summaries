import {Component, OnInit} from '@angular/core';
import {BookService} from "../../services/book.service";
import {Book} from "../../interfaces/book";
import {Router} from "@angular/router"; // Adjust the relative path as needed
// Adjust the relative path as needed

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements  OnInit{

  public books: Book[] | undefined ;

  constructor(private service: BookService,private router: Router) {}
  ngOnInit(){
    this.service.getAllBooks().subscribe(data=>{
      this.books= data;})

  }
  showBook(id:number){
    this.router.navigate(["/show-book/"+id])


}



}
