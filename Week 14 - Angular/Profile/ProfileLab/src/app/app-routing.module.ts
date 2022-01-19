import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfileDisplayComponent } from './profile-display/profile-display.component';

const routes: Routes = [
  { path: "Display", component: ProfileDisplayComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
