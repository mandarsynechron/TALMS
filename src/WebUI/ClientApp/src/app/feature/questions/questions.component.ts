import { Component, OnInit } from '@angular/core';
import { Questions, QuestionClient } from '../../TALMS-api';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html'
})
export class QuestionsComponent implements OnInit {
  title = Questions.name;
  questionList$: Observable<Array<Questions>>;
  constructor(private questionService: QuestionClient) { }

  ngOnInit(): void {
    this.questionList$ = this.questionService.get();
  }
}
