```mermaid
classDiagram
    class Student {
      +int studentID
      +String name
      +String email
      +List~Course~ courses
      +enrollInCourse(Course)
      +viewGrades()
    }

    class Course {
      +int courseID
      +String courseName
      +Instructor instructor
      +List~Assignment~ assignments
      +List~Resource~ resources
      +List~Discussion~ discussions
      +List~Quiz~ quizzes
      +accessCourseMaterial()
      +participateInDiscussion(Discussion)
      +submitAssignment(Assignment)
      +takeQuiz(Quiz)
    }

    class Instructor {
      +int instructorID
      +String name
      +getCourseDetails()
    }

    class Assignment {
      +int assignmentID
      +String title
      +Date dueDate
      +String description
      +Submission submission
      +viewDetails()
      +uploadSubmission(Submission)
    }

    class Resource {
      +int resourceID
      +String title
      +String type
      +String contentURL
      +downloadResource()
    }

    class Discussion {
      +int discussionID
      +String title
      +List~Post~ posts
      +createPost(Post)
      +viewPosts()
    }

    class Post {
      +int postID
      +User author
      +String content
      +DateTime timestamp
      +writeReply(Post)
    }

    class Quiz {
      +int quizID
      +String title
      +List~Question~ questions
      +Grade grade
      +startQuiz()
      +submitAnswers(List~Answer~)
    }

    class Submission {
      +int submissionID
      +Student student
      +Assignment assignment
      +DateTime timestamp
      +String content
      +uploadContent(String)
      +viewFeedback()
    }

    class Question {
      +int questionID
      +String text
      +List~String~ answerOptions
      +String correctAnswer
      +selectAnswer(String)
    }

    class Grade {
      +int gradeID
      +float score
      +String feedback
      +viewScore()
      +viewFeedback()
    }

    Student "1" -- "*" Course : enrolled in
    Course "1" -- "1" Instructor : taught by
    Course "*" -- "*" Assignment : includes
    Course "*" -- "*" Resource : contains
    Course "*" -- "*" Discussion : facilitates
    Course "*" -- "*" Quiz : assesses
    Assignment "1" -- "1" Submission : has
    Discussion "*" -- "*" Post : consists of
    Quiz "1" -- "*" Question : composed of
    Quiz "1" -- "1" Grade : results in
    Submission "*" -- "1" Student : submitted by
    Submission "*" -- "1" Assignment : related to