<?xml version='1.0' encoding='utf-16'?>
<!--  (c) 2006 LearnLift   -->
<!--  MemoryLifter Stylesheet   -->
<!--  Version 2.0 Date: 2007-10-08   -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template name="style">
    <![CDATA[

	.question
	{
		color:		#000000;
	}

	.questionExample
	{
		color:		#000000;
	}

	.answer
	{
		color:		#000000;
	}

	.answerExample
	{
		color:		#000000;
	}

  .answerCorrect
	{
		background-color:	#ffffff;
		color:		#000000;
	}

	.answerWrong
	{
		background-color:	#ffffff;
		color:		#000000;
	}

  .closebarCorrect { background-color: #53905C; }

  .closebarWrong { background-color: #E7504A; }

  .feedbackCorrect { background-color: #FFFFFF; }

  .feedbackWrong { background-color: #FFFFFF; }
  
  #questionHeader:hover
  {
	  background-color: #ddeeff;
  }

  #questionExample:hover
  {
	  background-color: #ddeeff;
  }

  #answerHeader:hover
  {
	  background-color: #ddeeff;
  }

  #answerExample:hover
  {
	  background-color: #ddeeff;
  }
  #feedbackImageCorrect
  {
	height: 150px;
	width: 150px;
  }
  #feedbackImageWrong
  {
	height: 150px;
	width: 150px;
  }
]]>
  </xsl:template>
</xsl:stylesheet>