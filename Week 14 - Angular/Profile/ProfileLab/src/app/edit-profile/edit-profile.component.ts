import { Component, OnInit } from '@angular/core';
import { User } from '../User';
import { UserService } from '../user.service';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css']
  //providers: [UserService, Router]
})
export class EditProfileComponent implements OnInit {

  userToEdit: any;
  profilePics: string[] = ["profilePic1.jpg", "profilePic2.png", "profilePic3.jpg", "profilePic4.jpg"];
  constructor(public userService: UserService) { }

  ngOnInit(): void {
    if (this.userService.User) {
      this.userToEdit = this.userService.User;
    }
    else {
      this.userToEdit = { name: "Bobby", contact: "XxXtremePineappleXxX@email.com", bio: "Likes pineapples", profilePic: "profilePic1.jpg" };

    }
  }
  UpdateUser(): void {
    let name: string = (<HTMLInputElement>document.getElementById("Name")).value;
    let contact: string = (<HTMLInputElement>document.getElementById("Contact")).value;
    let bio: string = (<HTMLInputElement>document.getElementById("Bio")).value;
    //let pic:string =  (<HTMLInputElement>document.getElementById("Bio")).value;
    let images = (<HTMLCollection>document.getElementsByClassName("imageSelection"));

    let selectedImage: string = "";
    for (let i = 0; i < images.length; i++) {
      let input = <HTMLInputElement>images[i];
      if (input.checked) {
        selectedImage = input.value;
      }
    }
    let u: User = { name: name, contact: contact, bio: bio, profilePic: selectedImage };

    //overriding an object persisted the changes 
    //where override properties did not 
    this.userService.User = u;
    console.log(this.userService.User);
  }
}
