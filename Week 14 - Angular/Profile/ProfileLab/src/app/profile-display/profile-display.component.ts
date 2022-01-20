import { Component, OnInit } from '@angular/core';
import { User } from '../User';
import { UserService } from '../user.service';

@Component({
  selector: 'app-profile-display',
  templateUrl: './profile-display.component.html',
  styleUrls: ['./profile-display.component.css']
  //providers: [UserService]
})
export class ProfileDisplayComponent implements OnInit {

  currentUser: any;

  //Inject the user service class
  constructor(private userService: UserService) { }

  ngOnInit(): void {
    //check whether User in my service is undefined 
    //if it is defined grab that user 
    //else fill in a default user 
    if (this.userService.User) {
      this.currentUser = this.userService.getUser();
    }
    else {
      this.currentUser = { name: "Bobby", contact: "XxXtremePineappleXxX@email.com", bio: "Likes pineapples", profilePic: "profilePic1.jpg" };

    }
  }

}
