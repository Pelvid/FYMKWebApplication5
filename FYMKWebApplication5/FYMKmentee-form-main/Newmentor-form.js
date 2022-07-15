const volunteeringTextArea = document.querySelector('#volunteering')
const volunteeringWordLength = document.querySelector('.volunteering-word-length')
const mentorExpectationTextArea = document.querySelector('#mentorExpectation')
const mentorExpectationWordLength = document.querySelector('.mentorExpectation-word-length')
const skillAndHobbiesTextArea = document.querySelector('#skills_hobbies_specialInterest')
const skillAndHobbiesWordLength = document.querySelector('.skillAndHobbies-word-length')
const specialNeedsTextArea = document.querySelector('#skills_hobbies_specialNeeds')
const specialNeedsWordLength = document.querySelector('.specialNeeds-word-length')
const finalNoteTextArea = document.querySelector('#finalNote')
const finalNoteWordLength = document.querySelector('.finalNote-word-length')
const submitBTN = document.querySelector('.submitBTN')


const form = document.querySelector('.form')
const firstName = document.querySelector('.firstName')
const lastName = document.querySelector('.lastName')
const address = document.querySelector('.address')
const addressLine1 = document.querySelector('.address-line1')
const addressLine2 = document.querySelector('.address-line2')
const city = document.querySelector('.city')
const stateProvinceRegion = document.querySelector('.stateProvinceRegion')
const postalCode = document.querySelector('.postalCode')
const country = document.querySelector('.country')
const telephone = document.querySelectorAll('.telephone')
const email = document.querySelector('.email')
const dateOfBirth = document.querySelector('.dateOfBirth')
const gender = document.querySelector('.gender')
const menteeAge16To18 = document.querySelector('.m16-18')
const menteeAge18To20 = document.querySelector('.m18-20')
const menteeAge21To25 = document.querySelector('.m21-25')
const menteeGenderPreference = document.querySelector('.menteeGenderPreference')
const criminalConviction = document.querySelector('.criminal-conviction')
const DBSCerticication = document.querySelector('.DBSCertification')
const DBSUpdatedNumber = document.querySelector('.DBSUpdatedNumber')
const industrySector = document.querySelector('.industrySector')
const jobTitle = document.querySelector('.jobTitle')
const currentEmployersName = document.querySelector('#currentEmployersName')
const currentEmployersAddress = document.querySelector('#currentEmployersAddress')
const startDateWithEmployer = document.querySelector('.startDateWithEmployer')
const volunteering = document.querySelector('#volunteering')
const mentorExpectation = document.querySelector('.mentorExpectation')
const textArea = document.querySelector('.textArea')
const employment = document.querySelector('.employment')
const entrepreneurship = document.querySelector('.entrepreneurship')
const education = document.querySelector('.education')
const universityApplications = document.querySelector('.university-applications')
const careerOptions = document.querySelector('.career-options')
const CVWriting = document.querySelector('.CV-writing')
const developingAProfessionalNetwork = document.querySelector('.developing_a_professional_network')
const gettingInvolvedInCommunityWork = document.querySelector('.getting_involved_in_community_work')
const changingCareer = document.querySelector('.changing_career')
const buildingConfidence = document.querySelector('.building_confidence')
const collegeOptions = document.querySelector('.college_options')
const careerWithoutUniversity = document.querySelector('.career_without_university')
const Volunteering = document.querySelector('.volunteering')
const interviewSkills = document.querySelector('.interview_skills')
const developingResilience = document.querySelector('.developing_resilience')
const findingJobsLocally = document.querySelector('.finding_jobs_locally')
const GDPRAgreement = document.querySelector('.GDPRAgreement')












const countAndRestrictWords = (textArea,wordLength)=>{

textArea.addEventListener('input',()=>{

let textAreaValue =  textArea.value
let txt = textAreaValue.trim();
let words = txt.split(/\s+/).filter((item) => item)

   wordLength.textContent = words.length;
   

  let clearExtraWords = ()=>{
let allowedWords = words.slice(0,100)
textArea.value = allowedWords.join(' ')
wordLength.textContent = allowedWords.length;
}

 if (words.length >= 101) clearExtraWords()

 })
}
countAndRestrictWords(volunteeringTextArea,volunteeringWordLength)
countAndRestrictWords(mentorExpectationTextArea,mentorExpectationWordLength)
countAndRestrictWords(skillAndHobbiesTextArea,skillAndHobbiesWordLength)
countAndRestrictWords(specialNeedsTextArea,specialNeedsWordLength)
countAndRestrictWords(finalNoteTextArea,finalNoteWordLength)




const validateForm = ()=>{
alert('bla bla bla')
}

form.onsubmit =(e)=>{                                                                                                          
  validateForm()
return false }