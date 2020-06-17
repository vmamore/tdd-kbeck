class TestCase:
    def __init__(self,name):
        self.name = name
    
    def run(self, result):
        result.testStarted()
        self.setUp()
        method = getattr(self, self.name)
        method()
        self.tearDown()
    
    def tearDown(self):
        pass

class WasRun(TestCase):
    def __init__(self,name):
        self.wasRun = None
        TestCase.__init__(self, name)

    def testMethod(self):
        self.wasRun = 1
        self.log = self.log + "testMethod"
    
    def setUp(self):
        self.wasRun = None
        self.wasSetUp = 1
        self.log = "setUp"

    def setUp(self):
        self.log = "setUp "
    
    def testMethod(self):
        self.log = self.log + "testMethod "

    def tearDown(self):
        self.log = self.log + "tearDown "

class TestCaseTest(TestCase):
    def setUp(self):
        self.test = WasRun("testMethod")

    def testTemplateMethod(self):
        test = WasRun("testMethod")
        test.run()
        assert("setUp testMethod tearDown" == self.test.log)

    def testRunning(self):
        self.test.run()
        assert(self.test.wasRun)

    def testSetUp(self):
        self.test.run()
        assert("setUp testMethod" == self.test.log)
    
TestCaseTest("testRunning").run()


