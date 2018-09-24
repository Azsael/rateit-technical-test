# RateIt technical test

## Introduction

The RateIt technical test is an ASP.NET Core 2.1 + Angular 6 app. It uses Entity Framework backed by SQlite to store data.

Candidates are requested to fork the repository, complete the tasks outlined and and submit a pull request when they're finished. The PR will then be reviewed in-person (or via Zoom) along with the rest of the technical interview.

### Requirements

#### Overview

RateIt's core business is capturing "ratings" from customer and displaying these to RateIt's clients who can then action the feedback. The technical test uses a heavily simplified model to represent consumer ratings being left against a customer company.

There are two pieces of rating data being captured in this datamodel: a text comment or a Net Promoter Score (NPS). Both are optional (and it's possible that there are ratings that have neither of these data points).

The datamodel is represented in three tables:

* **Company** - Represents the company that is collecting the ratings.
* **Rating** - Represents an individual "rating" performed by a customer.
* **RatingResult** - Represents a type of result assigned to the rating. This could be an NPS score or a text comment.

By default, the application will launch an Angular 6 application with a `router-outlet` to display a component.

Clients like to be able to view the NPS trends, so they can get an idea of how they are tracking over time. These trends might be grouped as a daily, weekly or monthly value.

#### Deliverables

The requested requirements are:

* A chart that displays the NPS trends for a selected company over time
* Ability to change company being analysed. This list should be populated from the database
* Ability to change the start and end date range of the ratings being analysed
* Ability to change the data grouping. The possible values should be Daily, Weekly or Monthly. These represent the "buckets" that ratings are grouped in for the NPS calculation
* Ratings should be grouped according to the Timezone assigned to the Company.

Below is a wireframe that illustrates how the UI should look. As it is low fidelity, we require candidates to use the existing CSS framework to deliver this piece of work, with an expectation that it looks professional and ready for users to use.
![wireframe](technical-test-wireframe.png)

### Technical Notes

#### CSS Framework

The test uses [Bulma](https://bulma.io/) as a base CSS framework. Please leverage this framework as much as possible rather than writing new CSS.


#### How to calculate NPS

NPS has some maths behind it that you will [need to be across](https://www.surveymonkey.com/mp/net-promoter-score-calculation/) to complete this work.

#### Highcharts

The test includes the [Highcharts Angular component](https://www.npmjs.com/package/angular-highcharts).

#### Timeframes

You have until your technical interview to complete this work. You will need to submit your pull request at least two hours before the interview to give us some time to review it. Good luck!

