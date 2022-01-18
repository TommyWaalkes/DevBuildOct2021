import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MathComponent } from './math/math.component';
import { TestComponent } from './test/test.component';

const routes: Routes = [
  //A route object needs 2 things 
  //A path for the component 
  //A Component to pull up along that path
  { path: 'example', component: TestComponent },
  { path: 'math', component: MathComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
